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

namespace MDI_sec1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void futureValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FutureValue fred = new FutureValue();
            fred.Show();
        }

        private void inclass01CalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mutidimentionalArraysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayWork fred = new ArrayWork();
            fred.MdiParent = this;
            fred.Show();
        }

        private void stringManipulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringManipulation fred = new StringManipulation();
            fred.Show();
        }
    }
}
