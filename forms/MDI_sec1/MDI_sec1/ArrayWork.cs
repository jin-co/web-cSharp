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
    public partial class ArrayWork : Form
    {
        string[,] reservations = new string[5, 6];
        


        string[] waiting = new string[10];
        Boolean seatsAvailable = true;

        public ArrayWork()
        {
            InitializeComponent();
        }


        private void ArrayWork_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            reservations[0, 3] = "Fred";
            reservations[1, 2] = "Mary";
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            btnReservations_Click(sender, e);

            
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            seatsAvailable = false;
            txtReservations.Text = "";
            for (int i=0; i< reservations.GetLength(0); i++)
            {
                string row = lstRow.Items[i].ToString();
                for(int j = 0; j < reservations.GetLength(1); j++)
                {
                    string seat = lstSeat.Items[j].ToString();
                    if (string.IsNullOrEmpty(reservations[i, j])) 
                        seatsAvailable = true;
                    txtReservations.Text += row + seat +
                        " - " + reservations[i, j] + "\n";
                }
            }
        }
    }
}
