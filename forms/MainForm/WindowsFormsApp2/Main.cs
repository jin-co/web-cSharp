using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void week2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Week2 fred = new Week2(); //instantiate
            fred.MdiParent = this; // this line limits the child from go out side the ream of parent
            fred.Show();
        }
    }
}
