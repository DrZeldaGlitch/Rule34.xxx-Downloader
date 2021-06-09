
namespace R34Downloader
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.AboutLabel = new MetroFramework.Controls.MetroLabel();
            this.AboutR34Site = new MetroFramework.Controls.MetroLink();
            this.AboutR34API = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Location = new System.Drawing.Point(12, 60);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(507, 209);
            this.AboutLabel.TabIndex = 0;
            this.AboutLabel.Text = resources.GetString("AboutLabel.Text");
            this.AboutLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AboutR34Site
            // 
            this.AboutR34Site.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.AboutR34Site.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.AboutR34Site.Location = new System.Drawing.Point(165, 272);
            this.AboutR34Site.Name = "AboutR34Site";
            this.AboutR34Site.Size = new System.Drawing.Size(212, 23);
            this.AboutR34Site.Style = MetroFramework.MetroColorStyle.Blue;
            this.AboutR34Site.TabIndex = 1;
            this.AboutR34Site.Text = "Rule34.xxx Site";
            this.AboutR34Site.UseStyleColors = true;
            this.AboutR34Site.Click += new System.EventHandler(this.AboutR34Site_Click);
            // 
            // AboutR34API
            // 
            this.AboutR34API.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.AboutR34API.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.AboutR34API.Location = new System.Drawing.Point(165, 301);
            this.AboutR34API.Name = "AboutR34API";
            this.AboutR34API.Size = new System.Drawing.Size(212, 23);
            this.AboutR34API.Style = MetroFramework.MetroColorStyle.Blue;
            this.AboutR34API.TabIndex = 2;
            this.AboutR34API.Text = "Rule34.xxx API";
            this.AboutR34API.UseStyleColors = true;
            this.AboutR34API.Click += new System.EventHandler(this.AboutR34API_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Location = new System.Drawing.Point(165, 330);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(212, 23);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink1.TabIndex = 3;
            this.metroLink1.Text = "Original by r34dlnew on Github";
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.AboutOriginal_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink2.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink2.Location = new System.Drawing.Point(165, 359);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(212, 23);
            this.metroLink2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink2.TabIndex = 4;
            this.metroLink2.Text = "Fork by DrZeldaGlitch on Github";
            this.metroLink2.UseStyleColors = true;
            this.metroLink2.Click += new System.EventHandler(this.AboutFork_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Image = global::R34Downloader.Properties.Resources.exit_icon;
            this.exitButton.Location = new System.Drawing.Point(497, 14);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(22, 23);
            this.exitButton.TabIndex = 19;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.AboutR34API);
            this.Controls.Add(this.AboutR34Site);
            this.Controls.Add(this.AboutLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.Resizable = false;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "About Rule34.xxx Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel AboutLabel;
        private MetroFramework.Controls.MetroLink AboutR34Site;
        private MetroFramework.Controls.MetroLink AboutR34API;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private System.Windows.Forms.Button exitButton;
    }
}