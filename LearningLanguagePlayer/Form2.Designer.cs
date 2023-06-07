namespace LearningLanguagePlayer
{
    partial class fullscreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fullscreenForm));
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.subtitleRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(-5, 22);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(1276, 464);
            this.videoPlayer.TabIndex = 0;
            // 
            // subtitleRichTextBox
            // 
            this.subtitleRichTextBox.BackColor = System.Drawing.Color.White;
            this.subtitleRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subtitleRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.subtitleRichTextBox.ForeColor = System.Drawing.Color.Black;
            this.subtitleRichTextBox.Location = new System.Drawing.Point(507, 492);
            this.subtitleRichTextBox.Name = "subtitleRichTextBox";
            this.subtitleRichTextBox.Size = new System.Drawing.Size(681, 82);
            this.subtitleRichTextBox.TabIndex = 1;
            this.subtitleRichTextBox.Text = "";
            this.subtitleRichTextBox.TextChanged += new System.EventHandler(this.subtitleRichTextBox_TextChanged);
            // 
            // fullscreenForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 979);
            this.Controls.Add(this.subtitleRichTextBox);
            this.Controls.Add(this.videoPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "fullscreenForm";
            this.Text = "FullscreenForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.RichTextBox subtitleRichTextBox;
    }
}