using nfs.View.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nfs
{
    public partial class WelcomePageForm : Form
    {
        public WelcomePageForm()
        {
            InitializeComponent();
        }

        private void btnExin_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("She si hodish li ? ", "exit ",
        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            dzSettings settings = new dzSettings();
            settings.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.Show();   
        }
    }
}
