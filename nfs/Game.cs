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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void btnGoToWelcomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePageForm frm = new WelcomePageForm();
            frm.Show();
        }
    }
}
