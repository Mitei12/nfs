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
    public partial class BlackList : Form
    {
        public BlackList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePageForm TowelcomePage = new WelcomePageForm();
            TowelcomePage.Show();
        }

        private void btnGoToLegendaryBoss_Click(object sender, EventArgs e)
        {
            this.Hide();
            LegenderyBoss legenderyBoss = new  LegenderyBoss();
            legenderyBoss.Show();   
        }
    }
}
