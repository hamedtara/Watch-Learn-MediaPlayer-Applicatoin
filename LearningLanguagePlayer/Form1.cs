using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;
using SubtitlesParser;
using SubtitlesParser.Classes;
using System.Drawing;

using System.Diagnostics;



namespace LearningLanguagePlayer
{
    public partial class Form1 : Form
    {
        private readonly FileLoader _fileLoader;
        List<string> filterFile = new List<string>();
        FolderBrowserDialog browserDialog = new FolderBrowserDialog();
        int currentFile = 0;
        List<SubtitleItem> subtitles;
        private Timer subtitleTimer;
        private readonly SubtitleLoader _subtitleLoader;
        private readonly MediaPlayerHandler mediaPlayerHandler;
        private ExcelPackage excelPackage;
        private ExcelWorksheet worksheet;
        private string defaultLanguages = "fa";

        // Event for video position change
        public event Action<double> VideoPositionChanged;


        public Form1()
        {
            InitializeComponent();

            _fileLoader = new FileLoader();

            subtitleTimer = new Timer();
            subtitleTimer.Interval = 100; // Check every 100 milliseconds
            subtitleTimer.Tick += UpdateSubtitle;
            _subtitleLoader = new SubtitleLoader();

            mediaPlayerHandler = new MediaPlayerHandler(mediaPlayer);
            subtitleRichTextBox.ContextMenuStrip = contextMenuStrip1;

            // Here we bind the event
            ggggToolStripMenuItem.Click += ggggToolStripMenuItem_Click;
            OxfordDictionary.Click += OxfordDictionary_Click;
            yarn.Click += yarn_Click;
            backButton.Click += backButton_Click;

            this.BackColor = Color.FromArgb(34, 34, 34);
            this.ForeColor = Color.Gold;
            subtitleRichTextBox.BackColor = Color.FromArgb(64, 64, 64);
            subtitleRichTextBox.ForeColor = Color.Gold;
            subtitleRichTextBox.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            menuStrip1.BackColor = Color.FromArgb(34, 34, 34);
            /*     contextMenuStrip1.BackColor = Color.FromArgb(34, 34, 34);*/
            playList.BackColor = Color.FromArgb(64, 64, 64);
            webView21.BackColor = subtitleRichTextBox.BackColor;

            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private void loadFolerEvent(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop();
            if (filterFile.Count > 1)
            {
                filterFile.Clear();
                playList.Items.Clear();
                currentFile = 0;
            }

            filterFile = _fileLoader.LoadFiles();

            mediaPlayerHandler.LoadMedia(filterFile);

            loadPlaylist();
        }

        private void mediaPlayerStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            mediaPlayerHandler.HandleMediaStateChange(e,
                onMediaPlaying: () =>
                {
                    lbl_duration.Text = "Duration: " + mediaPlayer.currentMedia.durationString;
                    subtitleTimer.Start();
                },
                onMediaStopped: () =>
                {
                    lbl_duration.Text = "Media Player stopped";
                    subtitleTimer.Stop();
                },
                onMediaReady: () => lbl_duration.Text = "Media Player Is Ready");

            if (e.newState == 8)
            {
                if (currentFile >= filterFile.Count - 1)
                {
                    currentFile = 0;
                }
                else
                {
                    currentFile += 1;
                }

                playList.SelectedIndex = currentFile;
                showFileName(fileName);
            }
            else if (e.newState == 9)
            {
                lbl_duration.Text = "Loading New Media";
            }
            else if (e.newState == 10)
            {
                lbl_duration.Text = "Buffering Started";
            }
        }

        private void playListChange(object sender, EventArgs e)
        {
            mediaPlayerHandler.HandlePlayListChange(playList, selectedItem =>
            {
                currentFile = playList.SelectedIndex;
                showFileName(fileName);
            });
        }

        private void loadPlaylist()
        {
            mediaPlayer.currentPlaylist = mediaPlayer.newPlaylist("", "");

            foreach (string medias in filterFile)
            {
                mediaPlayer.currentPlaylist.appendItem(mediaPlayer.newMedia(medias));
                playList.Items.Add(medias);
            }

            if (filterFile.Count > 0)
            {
                fileName.Text = "Files Found: " + filterFile.Count;
                playList.SelectedIndex = currentFile;
                PlayFile(playList.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Files Not Found in folder: only video and mp3 files are supported.");
            }
        }

        private void PlayFile(string url)
        {
            // Load subtitles for the current video
            string subtitleFilePath = Path.ChangeExtension(filterFile[currentFile], ".srt");

            subtitles = _subtitleLoader.LoadSubtitles(subtitleFilePath);
        }

        private void UpdateSubtitle(object sender, EventArgs e)
        {
            if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                var currentTime = mediaPlayer.Ctlcontrols.currentPosition * 1000; // convert to milliseconds

                var currentSubtitle = subtitles
                    .Where(s => currentTime >= s.StartTime && currentTime <= s.EndTime)
                    .FirstOrDefault();

                if (currentSubtitle != null)
                {
                    subtitleRichTextBox.Text = string.Join(Environment.NewLine, currentSubtitle.Lines);
                    // Trigger the event to notify the fullscreenForm about the subtitle change
                    VideoPositionChanged?.Invoke(currentTime);
                }
                else
                {
                    subtitleRichTextBox.Text = string.Empty;
                }
                subtitleRichTextBox.SelectAll();
                subtitleRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
                subtitleRichTextBox.DeselectAll();
            }
        }

        private void loadSubtitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Subtitle Files|*.srt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string subtitleFilePath = openFileDialog.FileName;

                // Load subtitles for the current video
                subtitles = _subtitleLoader.LoadSubtitles(subtitleFilePath);
            }
        }

        private void showAboutEvent(object sender, EventArgs e)
        {
            MessageBox.Show("This app is created by Hamed Tara." + Environment.NewLine + "I hope this application helps you learn English more efficiently." + Environment.NewLine + "Feel free to contact me via email: hamedtara@gmail.com.");

        }

        private void timerEvent(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            // Get the current video time in milliseconds
            double currentTime = mediaPlayer.Ctlcontrols.currentPosition * 1000;

            // Find the active subtitle for the current time
            SubtitleItem activeSubtitle = subtitles.FirstOrDefault(s => TimeSpan.FromMilliseconds(s.StartTime).TotalMilliseconds <= currentTime && currentTime <= TimeSpan.FromMilliseconds(s.EndTime).TotalMilliseconds);

            // Display the active subtitle
            if (activeSubtitle != null)
            {
                subtitleRichTextBox.Text = activeSubtitle.Lines.FirstOrDefault();
            }
            else
            {
                subtitleRichTextBox.Text = string.Empty;
            }

            // Start the timer again
            timer1.Start();
        }

        private void showFileName(Label name)
        {
            string file = Path.GetFileName(playList.SelectedItem.ToString());
            name.Text = "Currently Playing: " + file;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void ggggToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backButton.Visible = false;
            // Get the selected text from the RichTextBox
            string selectedText = subtitleRichTextBox.SelectedText;

            if (!string.IsNullOrEmpty(selectedText))
            {
                // Encode the selected text to be used in a URL
                string encodedText = System.Web.HttpUtility.UrlEncode(selectedText);

                // Create the URL for Google Translate using the default language
                string url = $"https://translate.google.com/#view=home&op=translate&sl=auto&tl={defaultLanguages}&text={encodedText}";

                // Load the translation page in the WebView2 control
                webView21.Source = new Uri(url);
                webView21.NavigationCompleted += (s, args) =>
                {
                    webView21.ExecuteScriptAsync("window.scrollBy(0, 150);");
                };
            }
        }

        private void OxfordDictionary_Click(object sender, EventArgs e)
        {
            backButton.Visible = true;

            // Get the selected word from the RichTextBox
            string selectedWord = subtitleRichTextBox.SelectedText;

            // Make sure a word was actually selected
            if (!string.IsNullOrWhiteSpace(selectedWord))
            {
                // Replace spaces with "+" symbols for the URL
                selectedWord = selectedWord.Replace(' ', '+');

                // Open the selected word in Google search "meaning of [word] in Oxford Dictionary"
                string url = $"https://www.google.com/search?q=the+meaning+of+{selectedWord}+in+dictionary";

                // Load the URL in the WebView2 control
                webView21.Source = new Uri(url);
            
            }
            else
            {
                MessageBox.Show("Please select a word before pressing the Oxford Dictionary button.", "No word selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void yarn_Click(object sender, EventArgs e)
        {
            // Get the selected word from the RichTextBox
            string selectedWord = subtitleRichTextBox.SelectedText;

            // Make sure a word was actually selected
            if (!string.IsNullOrWhiteSpace(selectedWord))
            {
                // Encode the selected word for URL
                string encodedWord = System.Web.HttpUtility.UrlEncode(selectedWord);

                // Navigate to the Yarn search URL in the WebView2 control
                string url = $"https://yarn.co/yarn-find?text={encodedWord}";
                webView21.Source = new Uri(url);

                // Scroll down in the WebView2 control after navigation completes
                webView21.NavigationCompleted += (s, args) =>
                {
                    webView21.ExecuteScriptAsync("window.scrollBy(0, 100);");
                };

                // Show the Back button
                backButton.Visible = true;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Go back to the previous page in the WebView2 control
            if (webView21.CanGoBack)
            {
                webView21.GoBack();
            }
            else
            {
                // Hide the Back button if there is no previous page to navigate to
                backButton.Visible = false;
            }
        }

        private void BackGoogle_Click(object sender, EventArgs e)
        {
            

        }

        private void addToExcel_Click(object sender, EventArgs e)
        {
            // Check if the excelPackage has been initialized (i.e. an Excel file is loaded)
            if (excelPackage == null)
            {
                // Ask user to create or load an Excel file
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Excel files|*.xlsx",
                    Title = "Open an Excel file"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Load the Excel file
                    var file = new FileInfo(filePath);
                    excelPackage = new ExcelPackage(file);
                }
                else
                {
                    MessageBox.Show("Please select an Excel file.", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Get the first worksheet in the workbook
            worksheet = excelPackage.Workbook.Worksheets.FirstOrDefault() ?? excelPackage.Workbook.Worksheets.Add("Sheet 1");

            // Get the selected text from the RichTextBox
            string selectedText = subtitleRichTextBox.SelectedText;

            // If a sentence is selected, add it to the Excel file
            if (!string.IsNullOrWhiteSpace(selectedText))
            {
                // Find the next empty row (starting from row 1)
                int row = 1;
                while (worksheet.Cells[row, 1].Value != null)
                {
                    row++;
                }

                // Add the selected text to the next empty row
                worksheet.Cells[row, 1].Value = selectedText;

                // Save the changes to the Excel file
                excelPackage.Save();
            }
        }

        private void defaultLanguage_Click(object sender, EventArgs e)
        {

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultLanguages = "en";
        }

        private void espanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultLanguages = "es";
        }

        private void arabicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultLanguages = "ar";
        }

        private void farsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultLanguages = "fa";
        }

        private void hindiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultLanguages = "hi";
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultLanguages = "ru";
        }

        private void manToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultLanguages = "de";
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultLanguages = "fr";
        }

        private void LaunchFullscreen()
        {
           
        }

        private void buttonFullscreen_Click(object sender, EventArgs e)
        {
            string videoURL = GetVideoURL();
            double currentPosition = GetCurrentPosition();
            string currentSubtitle = subtitleRichTextBox.Text;

            // Retrieve the subtitles for the current video
            string subtitleFilePath = Path.ChangeExtension(filterFile[currentFile], ".srt");
            List<SubtitleItem> subtitles = _subtitleLoader.LoadSubtitles(subtitleFilePath);

            fullscreenForm fullscreenForm = new fullscreenForm(videoURL, currentPosition, currentSubtitle, subtitles);
            fullscreenForm.ShowDialog();
            // Any actions you want to perform after fullscreenForm is closed
        }




        public string GetVideoURL()
        {
            if (currentFile >= 0 && currentFile < filterFile.Count)
            {
                return filterFile[currentFile];
            }
            else
            {
                return null;
            }
        }


        public double GetCurrentPosition()
        {
            double currentPosition = mediaPlayer.Ctlcontrols.currentPosition;
            Debug.WriteLine($"GetCurrentPosition: {currentPosition}"); // Debug statement to check the value
            return currentPosition;
        }



      



        private void mediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        public string GetCurrentSubtitle()
        {
            return subtitleRichTextBox.Text;
        }



    }
}
