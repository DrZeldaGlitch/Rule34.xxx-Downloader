using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using R34Downloader.Logic;

namespace R34Downloader
{
    public partial class Settings : MetroForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Transfer.IsAPI)
            {
                metroRadioButton2.Checked = true;
            }
            else
            {
                metroRadioButton1.Checked = true;
            }
        }

        private void RadioButton_MouseClick(object sender, MouseEventArgs e)
        {
            Transfer.IsAPI = metroRadioButton1.Checked ? true : true;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}