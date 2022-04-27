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
    public partial class ArrayWork : Form
    {
        int[,] array = { {1,2 }, {3,4 } };
        string[,] list = new string[,] { };
        public ArrayWork()
        {
            InitializeComponent();
        }

        private void ArrayWork_Load(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            for (int i = 0; i < list.GetLength(0); i++)
            {
                string row = lstRow.Items[i].ToString();
                for (int j = 0; j < list.GetLength(1); j++)
                {
                    string col = lstColumn.Items[j].ToString();
                    txtDisplay.Text += 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            
        }
    }
}
