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
    public partial class LegenderyBoss : Form
    {
        public LegenderyBoss()
        {
            InitializeComponent();
        }

        private void btnLegendaryExit_Click(object sender, EventArgs e)
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

        private void btnMotivaciq_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMotivation motivaciq = new FormMotivation();
            motivaciq.Show();
        }
    }
}
