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
    public partial class dzSettings : Form
    {
        public dzSettings()
        {
            InitializeComponent();
        }

        private void btnSettExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("She si hodish li ? ", "exit ",
        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            if (dialogResult == DialogResult.No)
            {
            }
        }

        private void btnVideoSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            VideoSettings VideoSettings = new VideoSettings();
            VideoSettings.Show();
        }

    }   
}
