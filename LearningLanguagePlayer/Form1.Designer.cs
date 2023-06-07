namespace LearningLanguagePlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSubtitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hindiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonFullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this.playList = new System.Windows.Forms.ListBox();
            this.fileName = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.subtitleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ggggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OxfordDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.yarn = new System.Windows.Forms.ToolStripMenuItem();
            this.addToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.backButton = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.defaultLanguage,
            this.buttonFullscreen});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.loadSubtitleToolStripMenuItem,
            this.aoutToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.loadFileToolStripMenuItem.Text = "Load Media";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFolerEvent);
            // 
            // loadSubtitleToolStripMenuItem
            // 
            this.loadSubtitleToolStripMenuItem.Name = "loadSubtitleToolStripMenuItem";
            this.loadSubtitleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.loadSubtitleToolStripMenuItem.Text = "Load Subtitle";
            this.loadSubtitleToolStripMenuItem.Click += new System.EventHandler(this.loadSubtitleToolStripMenuItem_Click);
            // 
            // aoutToolStripMenuItem
            // 
            this.aoutToolStripMenuItem.Name = "aoutToolStripMenuItem";
            this.aoutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.aoutToolStripMenuItem.Text = "About";
            this.aoutToolStripMenuItem.Click += new System.EventHandler(this.showAboutEvent);
            // 
            // defaultLanguage
            // 
            this.defaultLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.espanishToolStripMenuItem,
            this.arabicToolStripMenuItem,
            this.farsiToolStripMenuItem,
            this.hindiToolStripMenuItem,
            this.russianToolStripMenuItem,
            this.manToolStripMenuItem,
            this.frenchToolStripMenuItem});
            this.defaultLanguage.ForeColor = System.Drawing.Color.Yellow;
            this.defaultLanguage.Name = "defaultLanguage";
            this.defaultLanguage.Size = new System.Drawing.Size(112, 20);
            this.defaultLanguage.Text = "Default Language";
            this.defaultLanguage.Click += new System.EventHandler(this.defaultLanguage_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // espanishToolStripMenuItem
            // 
            this.espanishToolStripMenuItem.Name = "espanishToolStripMenuItem";
            this.espanishToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.espanishToolStripMenuItem.Text = "Espanish";
            this.espanishToolStripMenuItem.Click += new System.EventHandler(this.espanishToolStripMenuItem_Click);
            // 
            // arabicToolStripMenuItem
            // 
            this.arabicToolStripMenuItem.Name = "arabicToolStripMenuItem";
            this.arabicToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.arabicToolStripMenuItem.Text = "Arabic";
            this.arabicToolStripMenuItem.Click += new System.EventHandler(this.arabicToolStripMenuItem_Click);
            // 
            // farsiToolStripMenuItem
            // 
            this.farsiToolStripMenuItem.Name = "farsiToolStripMenuItem";
            this.farsiToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.farsiToolStripMenuItem.Text = "Farsi";
            this.farsiToolStripMenuItem.Click += new System.EventHandler(this.farsiToolStripMenuItem_Click);
            // 
            // hindiToolStripMenuItem
            // 
            this.hindiToolStripMenuItem.Name = "hindiToolStripMenuItem";
            this.hindiToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.hindiToolStripMenuItem.Text = "Hindi";
            this.hindiToolStripMenuItem.Click += new System.EventHandler(this.hindiToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.russianToolStripMenuItem.Text = "Russian";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // manToolStripMenuItem
            // 
            this.manToolStripMenuItem.Name = "manToolStripMenuItem";
            this.manToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.manToolStripMenuItem.Text = "German";
            this.manToolStripMenuItem.Click += new System.EventHandler(this.manToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.frenchToolStripMenuItem.Text = "French";
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // buttonFullscreen
            // 
            this.buttonFullscreen.ForeColor = System.Drawing.Color.Yellow;
            this.buttonFullscreen.Name = "buttonFullscreen";
            this.buttonFullscreen.Size = new System.Drawing.Size(72, 20);
            this.buttonFullscreen.Text = "Fullscreen";
            this.buttonFullscreen.Click += new System.EventHandler(this.buttonFullscreen_Click);
            // 
            // playList
            // 
            this.playList.FormattingEnabled = true;
            this.playList.ItemHeight = 16;
            this.playList.Location = new System.Drawing.Point(1003, 23);
            this.playList.Margin = new System.Windows.Forms.Padding(4);
            this.playList.Name = "playList";
            this.playList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playList.Size = new System.Drawing.Size(155, 420);
            this.playList.TabIndex = 2;
            this.playList.SelectedIndexChanged += new System.EventHandler(this.playListChange);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(13, 322);
            this.fileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(69, 16);
            this.fileName.TabIndex = 3;
            this.fileName.Text = "File Name";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(908, 322);
            this.lbl_duration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(70, 16);
            this.lbl_duration.TabIndex = 4;
            this.lbl_duration.Text = "Duration :0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timerEvent);
            // 
            // subtitleRichTextBox
            // 
            this.subtitleRichTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.subtitleRichTextBox.ForeColor = System.Drawing.Color.Yellow;
            this.subtitleRichTextBox.Location = new System.Drawing.Point(1, 411);
            this.subtitleRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subtitleRichTextBox.Name = "subtitleRichTextBox";
            this.subtitleRichTextBox.Size = new System.Drawing.Size(1157, 52);
            this.subtitleRichTextBox.TabIndex = 5;
            this.subtitleRichTextBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ggggToolStripMenuItem,
            this.OxfordDictionary,
            this.yarn,
            this.addToExcel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ggggToolStripMenuItem
            // 
            this.ggggToolStripMenuItem.Name = "ggggToolStripMenuItem";
            this.ggggToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ggggToolStripMenuItem.Text = "Google Translate";
            this.ggggToolStripMenuItem.Click += new System.EventHandler(this.ggggToolStripMenuItem_Click);
            // 
            // OxfordDictionary
            // 
            this.OxfordDictionary.Name = "OxfordDictionary";
            this.OxfordDictionary.Size = new System.Drawing.Size(168, 22);
            this.OxfordDictionary.Text = "Oxford Dictionary";
            this.OxfordDictionary.Click += new System.EventHandler(this.OxfordDictionary_Click);
            // 
            // yarn
            // 
            this.yarn.Name = "yarn";
            this.yarn.Size = new System.Drawing.Size(168, 22);
            this.yarn.Text = "Yarn";
            this.yarn.Click += new System.EventHandler(this.yarn_Click);
            // 
            // addToExcel
            // 
            this.addToExcel.Name = "addToExcel";
            this.addToExcel.Size = new System.Drawing.Size(168, 22);
            this.addToExcel.Text = "Add To Excel";
            this.addToExcel.Click += new System.EventHandler(this.addToExcel_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.Color.White;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            this.webView21.Location = new System.Drawing.Point(2, 468);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1158, 243);
            this.webView21.TabIndex = 7;
            this.webView21.ZoomFactor = 1D;
            // 
            // backButton
            // 
            this.backButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.backButton.Location = new System.Drawing.Point(7, 478);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.AllowDrop = true;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(2, 20);
            this.mediaPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(1002, 391);
            this.mediaPlayer.TabIndex = 0;
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayerStateChange);
            this.mediaPlayer.Enter += new System.EventHandler(this.mediaPlayer_Enter);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.subtitleRichTextBox);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.playList);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watch&Learn";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aoutToolStripMenuItem;
        private System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox subtitleRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem loadSubtitleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ggggToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OxfordDictionary;
        private System.Windows.Forms.ToolStripMenuItem yarn;
        private System.Windows.Forms.ToolStripMenuItem addToExcel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ToolStripMenuItem defaultLanguage;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espanishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farsiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hindiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.ToolStripMenuItem buttonFullscreen;
    }
}

