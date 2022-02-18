using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nfs.View.Settings
{
    public partial class VideoSettings : Form
    {
        public VideoSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picBox.Load(@"C:/Users/matei/Desktop/programmingJoke.jpg");
        }

        private void btnGoToWelcomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePageForm GoTowelcomePage = new WelcomePageForm();
            GoTowelcomePage.Show();
        }

        private void btnVideoExit_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoryForm HistoryForm = new HistoryForm();
            HistoryForm.Show();
        }

        private void btnVideoExit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
