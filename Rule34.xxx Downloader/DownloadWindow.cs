using MetroFramework.Forms;
using R34Downloader.Logic;
using System.Windows.Forms;
using System;

namespace R34Downloader
{
    public partial class DownloadWindow : MetroForm
    {
        private readonly int maxPid = 0;
        public DownloadWindow(int maxPid)
        {
            InitializeComponent();
            this.maxPid = maxPid;
        }

        private void DownloadWindow_Load(object sender, EventArgs e)
        {
            if (maxPid < 11111)
            {
                metroTrackBar.Maximum = maxPid;
                numericUpDown1.Maximum = maxPid;
            }
            else
            {
                label2.Text = "11111 max ;)";
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                ((CheckBox)sender).Text = ((CheckBox)sender).Text.Remove(((CheckBox)sender).Text.Length - 1);
            else
                ((CheckBox)sender).Text += "*";

            label1.Visible = (metroCheckBox1.Checked && metroCheckBox2.Checked && metroCheckBox3.Checked) ? false : true;
        }

        private void MetroTrackBar_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = metroTrackBar.Value;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            metroTrackBar.Value = Convert.ToInt32(numericUpDown1.Value);
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Transfer.Limit = metroTrackBar.Value;
            Transfer.Images = metroCheckBox1.Checked;
            Transfer.Gif = metroCheckBox2.Checked;
            Transfer.Video = metroCheckBox3.Checked;
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


