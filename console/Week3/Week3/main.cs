using HelloWorld;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author:\tDavid Turton\n" +
                "Email:\tlilijk@hanmail.net\n" +
                "Phone:\t519-569-5220", "About My Code",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void futureValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FutureValue futureValue = new FutureValue();
            futureValue.MdiParent = this;
            futureValue.Show();
        }

        private void arrayWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayWork arrayWork = new ArrayWork();
            arrayWork.MdiParent = this;
            arrayWork.Show();
        }
    }
}
