using SubtitlesParser.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LearningLanguagePlayer
{
    public partial class fullscreenForm : Form
    {
        private string videoURL;
        private double startPosition;
        private string subtitleText;
        private List<SubtitleItem> subtitles;
        private Timer subtitleTimer;

        public fullscreenForm()
        {
            InitializeComponent();
        }

        public fullscreenForm(string videoURL, double startPosition, string subtitleText, List<SubtitleItem> subtitles)
        {
            InitializeComponent();

            this.videoURL = videoURL;
            this.startPosition = startPosition;
            this.subtitleText = subtitleText;
            this.subtitles = subtitles;

            this.Load += fullscreenForm_Load;
        }

        private void fullscreenForm_Load(object sender, EventArgs e)
        {
            videoPlayer.URL = videoURL;
            subtitleRichTextBox.Text = subtitleText;

            // Set the video player's current position
            videoPlayer.Ctlcontrols.currentPosition = startPosition;

            // Start the timer to update the subtitle
            subtitleTimer = new Timer();
            subtitleTimer.Interval = 100; // Update every 100 milliseconds
            subtitleTimer.Tick += SubtitleTimer_Tick;
            subtitleTimer.Start();

            // Wait for the video to load
            videoPlayer.PlayStateChange += VideoPlayer_PlayStateChange;
            subtitleRichTextBox.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void SubtitleTimer_Tick(object sender, EventArgs e)
        {
            double currentTime = videoPlayer.Ctlcontrols.currentPosition * 1000; // Convert to milliseconds
            UpdateSubtitle(currentTime);
        }

        private void UpdateSubtitle(double currentTime)
        {
            var currentSubtitle = subtitles
                .Find(s => currentTime >= s.StartTime && currentTime <= s.EndTime);

            if (currentSubtitle != null)
            {
                subtitleRichTextBox.Text = string.Join(Environment.NewLine, currentSubtitle.Lines);
            }
            else
            {
                subtitleRichTextBox.Text = string.Empty;
            }
        }

        private void VideoPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Check if the video has finished playing
            if (e.newState == 8) // MediaEnded
            {
                // Stop the subtitle timer
                subtitleTimer.Stop();

                // Stop video playback when the form is closed
                videoPlayer.Ctlcontrols.stop();
            }
        }
        private void subtitleRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullscreenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Stop video playback when the form is closed
            videoPlayer.Ctlcontrols.stop();

            // Release the COM objects
            if (videoPlayer != null)
            {
                videoPlayer.Dispose();
                videoPlayer = null;
            }

            // Unsubscribe from the PlayStateChange event
            if (videoPlayer != null)
            {
                videoPlayer.PlayStateChange -= VideoPlayer_PlayStateChange;
            }
        }

    }
}
