using MetroFramework.Forms;
using System.Diagnostics;

namespace R34Downloader
{
    public partial class AboutWindow : MetroForm
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void AboutR34Site_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://rule34.xxx");
        }

        private void AboutR34API_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://rule34.xxx/index.php?page=help&topic=dapi");
        }

        private void AboutOriginal_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://github.com/r34dlnew/Rule34.xxx-Downloader");
        }

        private void AboutFork_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://github.com/DrZeldaGlitch/Rule34.xxx-Downloader");
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
