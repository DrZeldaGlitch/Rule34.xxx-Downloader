namespace R34Downloader
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.SearchBox = new MetroFramework.Controls.MetroTextBox();
            this.SearchButton = new MetroFramework.Controls.MetroButton();
            this.DownloadButton = new MetroFramework.Controls.MetroButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.WelcomeStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.DownContentStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SearchHelpButton = new MetroFramework.Controls.MetroButton();
            this.AboutButton = new MetroFramework.Controls.MetroButton();
            this.SettingsButton = new MetroFramework.Controls.MetroButton();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.AboutLabel = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(23, 269);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PromptText = "Type your Tag here";
            this.SearchBox.Size = new System.Drawing.Size(481, 23);
            this.SearchBox.Style = MetroFramework.MetroColorStyle.Green;
            this.SearchBox.TabIndex = 0;
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(132, 298);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(136, 30);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(274, 298);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(136, 30);
            this.DownloadButton.TabIndex = 2;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WelcomeStripStatus,
            this.toolStripProgressBar1,
            this.DownContentStrip});
            this.statusStrip1.Location = new System.Drawing.Point(20, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(487, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // WelcomeStripStatus
            // 
            this.WelcomeStripStatus.AutoSize = false;
            this.WelcomeStripStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.WelcomeStripStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WelcomeStripStatus.Name = "WelcomeStripStatus";
            this.WelcomeStripStatus.Size = new System.Drawing.Size(60, 17);
            this.WelcomeStripStatus.Text = "Welcome!";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // DownContentStrip
            // 
            this.DownContentStrip.AutoSize = false;
            this.DownContentStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DownContentStrip.Name = "DownContentStrip";
            this.DownContentStrip.Size = new System.Drawing.Size(133, 17);
            this.DownContentStrip.Text = "0 / 0";
            // 
            // SearchHelpButton
            // 
            this.SearchHelpButton.Location = new System.Drawing.Point(200, 334);
            this.SearchHelpButton.Name = "SearchHelpButton";
            this.SearchHelpButton.Size = new System.Drawing.Size(68, 23);
            this.SearchHelpButton.TabIndex = 16;
            this.SearchHelpButton.Text = "Search Help";
            this.SearchHelpButton.Click += new System.EventHandler(this.SearchHelpButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(274, 334);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 17;
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(355, 334);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(55, 23);
            this.SettingsButton.TabIndex = 18;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Image = global::R34Downloader.Properties.Resources.exit_icon;
            this.ExitButton.Location = new System.Drawing.Point(501, 13);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(22, 23);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::R34Downloader.Properties.Resources.header;
            this.PictureBox.Location = new System.Drawing.Point(5, 51);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(518, 212);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Location = new System.Drawing.Point(155, 360);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(255, 19);
            this.AboutLabel.TabIndex = 19;
            this.AboutLabel.Text = "For Info about this Application, see About.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.ControlBox = false;
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.SearchHelpButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Rule34.xxx Downloader";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroTextBox SearchBox;
        private MetroFramework.Controls.MetroButton SearchButton;
        private MetroFramework.Controls.MetroButton DownloadButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel WelcomeStripStatus;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel DownContentStrip;
        private MetroFramework.Controls.MetroButton SearchHelpButton;
        private MetroFramework.Controls.MetroButton AboutButton;
        private MetroFramework.Controls.MetroButton SettingsButton;
        private MetroFramework.Controls.MetroLabel AboutLabel;
    }
}