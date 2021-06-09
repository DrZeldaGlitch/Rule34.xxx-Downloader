using System;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using R34Downloader.Logic;
using MetroFramework.Forms;

namespace R34Downloader
{
    public partial class MainWindow : MetroForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Transfer.IsAPI = true;
            WelcomeStripStatus.Text = "Welcome!";
            DownContentStrip.Text = "0 / 0";

            if (Properties.Settings.Default.Path != null || Properties.Settings.Default.Path != "")
            {
                folderBrowserDialog1.SelectedPath = Properties.Settings.Default.Path;
            }

            if (!CheckForInternetConnection("https://rule34.xxx"))
            {
                if (MessageBox.Show("You are offline please check your internet connection", "Unable to connect to the Rule34.xxx", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    Form1_Load(sender, e);
                }
                else
                {
                    Close();
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                WelcomeStripStatus.Text = "Searching...";
                string request = SearchBox.Text.Replace(' ', '+').Replace("*", "%2a");
                if (Transfer.IsAPI)
                {
                    int countContent = R34API.GetCountContent(request);
                    if (countContent > 0)
                    {
                        WelcomeStripStatus.Text = "Search completed";
                        if (MessageBox.Show(countContent + " results found. Open in a browser?", "Searching results", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Process.Start("https://rule34.xxx/index.php?page=post&s=list&tags=" + request);
                        }
                    }
                    else
                    {
                        WelcomeStripStatus.Text = "Search completed";
                        MessageBox.Show("Nobody here but us chickens!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (R34Parser.IsSomethingFound(request))
                    {
                        int countContent = R34Parser.GetCountContent(request, R34Parser.GetMaxPid(request));
                        if (countContent > 0)
                        {
                            WelcomeStripStatus.Text = "Search completed";
                            if (MessageBox.Show(countContent + " results found. Open in a browser?", "Searching results", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                Process.Start("https://rule34.xxx/index.php?page=post&s=list&tags=" + request);
                            }
                        }
                        else
                        {
                            WelcomeStripStatus.Text = "Search completed";
                            MessageBox.Show("Unable to search this deep in temporarily (error on site)", "Search error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        WelcomeStripStatus.Text = "Search completed";
                        MessageBox.Show("Nobody here but us chickens!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                WelcomeStripStatus.Text = "Search error";
                MessageBox.Show(exp.Message, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                string request = SearchBox.Text.Replace(' ', '+').Replace("*", "%2a");
                if (Transfer.IsAPI)
                {
                    int countContent = R34API.GetCountContent(request);
                    if (countContent > 0)
                    {
                        if (folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
                        {
                            Properties.Settings.Default.Path = folderBrowserDialog1.SelectedPath;
                            Properties.Settings.Default.Save();

                            DownloadWindow dlf = new DownloadWindow(countContent);
                            dlf.ShowDialog();

                            if (Transfer.Limit > 0)
                            {
                                WelcomeStripStatus.Text = "Downloading content...";
                                toolStripProgressBar1.Maximum = Transfer.Limit;

                                var progress = new Progress<int>(s => toolStripProgressBar1.Value = s);
                                var progress2 = new Progress<int>(s => DownContentStrip.Text = s + " / " + Transfer.Limit);
                                await Task.Factory.StartNew(() => R34API.DownloadContent(request, folderBrowserDialog1.SelectedPath, progress, progress2, Transfer.Limit), TaskCreationOptions.LongRunning);

                                WelcomeStripStatus.Text = "Download completed";
                                if (MessageBox.Show("Download completed! Open the folder?", "Download completed", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    Process.Start(folderBrowserDialog1.SelectedPath);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nobody here but us chickens!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else // If parsing method
                {
                    if (R34Parser.IsSomethingFound(request))
                    {
                        if (folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
                        {
                            Properties.Settings.Default.Path = folderBrowserDialog1.SelectedPath;
                            Properties.Settings.Default.Save();

                            int countContent = R34Parser.GetCountContent(request, R34Parser.GetMaxPid(request));
                            DownloadWindow dlf;
                            if (countContent > 0)
                            {
                                dlf = new DownloadWindow(countContent);
                            }
                            else
                            {
                                dlf = new DownloadWindow(11111);
                            }
                            dlf.ShowDialog();

                            if (Transfer.Limit > 0)
                            {
                                WelcomeStripStatus.Text = "Downloading content...";
                                toolStripProgressBar1.Maximum = Transfer.Limit;

                                var progress = new Progress<int>(s => toolStripProgressBar1.Value = s);
                                var progress2 = new Progress<int>(s => DownContentStrip.Text = s + " / " + Transfer.Limit);
                                await Task.Factory.StartNew(() => R34Parser.DownloadPages(request, folderBrowserDialog1.SelectedPath, progress, progress2, Transfer.Limit), TaskCreationOptions.LongRunning);

                                WelcomeStripStatus.Text = "Download completed";
                                if (MessageBox.Show("Download completed. Open the folder?", "Download completed", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    Process.Start(folderBrowserDialog1.SelectedPath);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nobody here but us chickens!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exp)
            {
                WelcomeStripStatus.Text = "Download error";
                MessageBox.Show(exp.Message, "Download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            new AboutWindow().Show();
        }

        private void SearchHelpButton_Click(object sender, EventArgs e)
        {
            string searchHelpMessage = "You can use:\n'*' all,\n(' ' or '+') union,\n'-' remove;\n\nFor example:\n > \"rainbow *\" - search for all tags starting with \"rainbow\"\n      rainbow_dash_(mlp)\n      rainbow_fur\n      rainbow_tail\n\n > \"mercy pharah animated\" - posts where there is \"mercy\", \"pharah\" and \"animated\" at the same time\n     \"fallout+elizabeth\"\n\n > \"tomb_raider -dickgirl -zoophilia\" - posts where there is \"tomb_raider\", but no \"dickgirl\" and \"zoophilia\"";
            MessageBox.Show(searchHelpMessage, "Search help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings sf = new Settings();
            sf.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static bool CheckForInternetConnection(string siteName)
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead(siteName))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
