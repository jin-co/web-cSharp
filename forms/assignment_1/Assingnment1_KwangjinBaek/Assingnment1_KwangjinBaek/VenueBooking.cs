using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingnment1_KwangjinBaek
{
    /* - Venue Booking Application written by Kwangjin Baek
     * this is a venue booking application
     * users can book customers to reservation list, cancel 
     * the reservation, or add to a waiting list 
     * when the reservation list is full
     */
    public partial class VenueBooking : Form
    {
        string[,] reservationList = new string[5,6];
        string[] waitingList = new string[10];
        int waitingListCount = 0, reservationListCount = 0;
        public VenueBooking()
        {
            InitializeComponent();
        }
        
        // check if there is a previous message written, if so clear.
        // display reservation list to the reservation list.
        private void btnShowAllReservations_Click(object sender, EventArgs e)
        {
            ClearAllMessage();
            if (richTextBox1.Text != "")
            {
                richTextBox1.Clear();
            }

            foreach (var i in reservationList)
            {
                if (i != null)
                {
                    richTextBox1.Text += i + "\n";
                }
            }
        }

        // check if there is a previous message written, if so clear.
        // display waiting list to the waiting list.
        private void btnShowWaitingList_Click(object sender, EventArgs e)
        {
            ClearAllMessage();
            DisplayWaitingList();
        }
        
        // check row, seat, and name are not blank.
        // reserve the seat if the seat is available and show a success message.
        // increment reserveListCount.
        // show message when the seat is not available.
        // show message if is fully booked.
        private void btnBook_Click(object sender, EventArgs e)
        {
            ClearAllMessage();
            if (lstRow.Text == "" || lstSeat.Text == "" || txtCustomerName.Text == "")
            {
                lblMessage.Text = "Please Enter Row\nPlease Enter Seat\nPlease Enter Name";
            }

            else
            {
                if (reservationList[lstRow.SelectedIndex, lstSeat.SelectedIndex] == null)
                {
                    reservationList[lstRow.SelectedIndex, lstSeat.SelectedIndex] =
                        lstRow.Text + lstSeat.Text + " - " + txtCustomerName.Text;
                    lblMessage.Text = "Reservation Successful";
                    reservationListCount++;
                }

                else if (reservationListCount == (lstRow.Items.Count * lstSeat.Items.Count))
                {
                    lblMessage.Text = "There Are No Seats Left";
                }

                else
                {
                    lblMessage.Text = "The Seat Is Not Available Please Choose Another Seat";
                    ShowAvailableSeats();
                }
            }
        }

        // check if there is available seat, 
        // if so show a message telling there is vacant seat.
        // add the customer to the waiting list only if no seats are available,
        // and show the success message.
        // show a message if waiting list is full.
        // increment waitiongListCount.
        private void btnAddToWaiting_Click(object sender, EventArgs e)
        {
            ClearAllMessage();
            if (reservationListCount < (lstRow.Items.Count * lstSeat.Items.Count))
            {
                lblMessage.Text = "There Are Available Seats";
                ShowAvailableSeats();
                return;
            }

            else
            {
                if (waitingListCount == waitingList.Length)
                {
                    lblMessage.Text = "Waiting List is Full";
                    DisplayWaitingList();
                    return;
                }

                else
                {
                    waitingList[waitingListCount] = txtCustomerName.Text;
                    lblMessage.Text = "Successfully Added To The Waiting List";
                    waitingListCount++;
                    return;
                }
            }
        }

        // check row and seat are not blank, if so show message.
        // check if the seat entered is reserved, if not show a message.
        // cancel the reservation.
        // check if there is a customer in the waiting list.
        // add the customer to the reservation list from the waiting list.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllMessage();
            if (lstRow.Text == "" || lstSeat.Text == "")
            {
                lblMessage.Text = "Please Enter Row\nPlease Enter Seat";
            }

            else
            {
                if (reservationList[lstRow.SelectedIndex, lstSeat.SelectedIndex] != null)
                {
                    string answer = MessageBox.Show(reservationList[lstRow.SelectedIndex,
                lstSeat.SelectedIndex], "CANCEL RESERVATION", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Asterisk).ToString();

                    if (answer == "Yes")
                    {
                        reservationList[lstRow.SelectedIndex, lstSeat.SelectedIndex] = null;
                        
                        if (waitingList[0] != null)
                        {
                            reservationList[lstRow.SelectedIndex, lstSeat.SelectedIndex] =
                                lstRow.Text + lstSeat.Text + " - " + waitingList[0];

                            for (int i = 0; i < waitingList.Length - 1; i++)
                            {
                                if (waitingList[i] != null)
                                {
                                    waitingList[i] = waitingList[i + 1];
                                }
                            }
                            lblMessage.Text = "Successfully Canceled\n" +
                                "Customer From The Waiting Successfully Added To The Reservation List";
                            waitingList[waitingListCount - 1] = null;
                            waitingListCount--;
                        }

                        else
                        {
                            reservationList[lstRow.SelectedIndex, lstSeat.SelectedIndex] = null;
                            reservationListCount--;
                            lblMessage.Text = "Successfully Canceled";
                        }
                    }
                }

                else
                {
                    lblMessage.Text = "The Seat Is Not Reserved\nPlease Check Again";
                }
            }
        }

        // fill all the seat with the same customer for a test.
        private void btnDebugFillAllSeat_Click(object sender, EventArgs e)
        {
            ClearAllMessage();
            for (int i = 0; i < lstRow.Items.Count; i++)
            {
                for (int j = 0; j < lstSeat.Items.Count; j++)
                {
                    reservationList[i,j] = lstRow.Items[i].ToString() + 
                        lstSeat.Items[j].ToString() + 
                        " - " + txtCustomerName.Text;
                }
            }
            reservationListCount = (lstRow.Items.Count * lstSeat.Items.Count);
        }

        // close the application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // show available seats left for reservation.
        private void ShowAvailableSeats()
        {
            lblAvailableSeats.Text = "Available Seats: ";
            for (int i = 0; i < lstRow.Items.Count; i++)
            {
                for (int j = 0; j < lstSeat.Items.Count; j++)
                {
                    if (reservationList[i, j] == null)
                    {
                        lblAvailableSeats.Text += lstRow.Items[i].ToString() +
                            lstSeat.Items[j].ToString() + " ";
                    }
                }
            }
        }

        // display the waiting list
        private void DisplayWaitingList()
        {
            IsWaitingListDisplayBoardEmpty();
            foreach (var k in waitingList)
            {
                if (k != null)
                {
                    richTextBox2.Text += k + "\n";
                }
            }
        }

        // check if previous waiting list exists on the board, if so clear
        private void IsWaitingListDisplayBoardEmpty()
        {
            if (richTextBox2.Text != "")
            {
                richTextBox2.Clear();
            }
        }

        // clear all the previous messages before running any of the buttons
        private void ClearAllMessage()
        {
            lblMessage.Text = "";
            lblAvailableSeats.Text = "";
        }
    }
}
