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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }
        private void btnHistoryExit_Click(object sender, EventArgs e)
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

        private void btnBlackList_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            BlackList blackList = new BlackList();  
            blackList.Show();
        }
    }
}
