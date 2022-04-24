using Assignment_4_KwangjinBaek_1.KBClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_KwangjinBaek_1
{
    // Assignment 4 Written by Kwangjin Baek / #8707943 / 2020.4.4.
    // this is shop maintenance application 
    // that allows shop owners to add, update or delete customers
    // with the details about the customer
    public partial class KBStockMaintenance : Form
    {
        #region variables
        double price = 0;
        int minutes = 0;
        string name = "";
        #endregion

        public KBStockMaintenance()
        {
            InitializeComponent();
        }

        // close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// On load, set the stock Id to 0 
        /// check if file exists
        /// show all the record from file onto the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KBStockMintenance_Load(object sender, EventArgs e)
        {
            txtStockId.Text = "0";
            KBStock.VerifyFile();
            UpdateListBox();
        }

        /// <summary>
        /// Clears the input areas for a new record.  
        /// Shows a message notifying that “this is a new record”.  
        /// Sets StockId to zero for a new item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearInputs_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "This is a new record";
            txtName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtMinutes.Text = "";
            chkIsProcedure.Checked = false;
            txtStockId.Text = "0";
        }

        /// <summary>
        /// create an object with its properties filled with input values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            string errorMessages = "";
            KBStock kbStock = new KBStock(txtName.Text);
            name = txtName.Text;

            try
            {
                #region Digit validation for price and minutes
                if (txtPrice.Text != "")
                {
                    if (!double.TryParse(txtPrice.Text, out price))
                    {
                        errorMessages += "Price: enter digits\n";
                    }
                }

                if (chkIsProcedure.Checked)
                {
                    if (!int.TryParse(txtMinutes.Text, out minutes))
                    {
                        errorMessages += "Minutes: enter digits\n";
                    }
                    else
                    {
                        if (minutes <= 0)
                        {
                            errorMessages += "Minutes: must be greater than 0\n";
                        }
                    }
                }
                else
                {
                    minutes = 0;
                }
                #endregion

                if (errorMessages == "")
                {
                    if (txtStockId.Text == "0")
                    {
                        kbStock.StockId = 0;
                        kbStock.Description = txtDescription.Text;
                        kbStock.Price = price;
                        kbStock.Minutes = minutes;
                        kbStock.IsProcedure = chkIsProcedure.Checked;
                        kbStock.KBAdd(kbStock);
                        txtMessages.Text = "Successfully saved";
                    }
                    else
                    {
                        kbStock.StockId = int.Parse(txtStockId.Text);
                        kbStock.Name = txtName.Text;
                        kbStock.Description = txtDescription.Text;
                        kbStock.Price = price;
                        kbStock.Minutes = minutes;
                        kbStock.IsProcedure = chkIsProcedure.Checked;
                        kbStock.KBUpdate(kbStock);
                        txtMessages.Text = "Successfully updated";
                    }
                }
            }
            catch (Exception ex)
            {
                txtMessages.Text += ex.Message + errorMessages;
            }
            UpdateListBox();
            KBStock kbStockForIndexing = KBStock.GetProvinceNameEqualOrGreater(name);
            lstStocks.SelectedValue = kbStockForIndexing.StockId;
            txtMessages.Text += errorMessages;
        }

        /// <summary>
        /// Delete a record by the given stock Id
        /// Update the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";

            //KBStock kbStock = KBStock.GetProvinceNameEqualOrGreater(txtName.Text);
            //lstStocks.SelectedValue = kbStock.StockId;
            try
            {
                KBStock.KBDelete(txtStockId.Text);
                name = txtName.Text;
                UpdateListBox();
                if (lstStocks.Items.Count > 0)
                {
                    KBStock kbStockForIndexing = KBStock.GetProvinceNameEqualOrGreater(name);
                    lstStocks.SelectedValue = kbStockForIndexing.StockId;
                }
                txtMessages.Text = "Successfully deleted";
            }
            catch (Exception ex)
            {
                txtMessages.Text += "Errors while deleting\n" + ex.Message;
            }
        }

        /// <summary>
        /// Return the input areas to their values before
        /// the user cleared or modified them 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            PopulateInputsWithSelectedList();
        }

        /// <summary>
        /// Populate the input box with the list a user click or whenever
        /// there are changes in index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstStocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateInputsWithSelectedList();
        }

        /// <summary>
        /// whenever a record selected, shows a message saying it is an update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstStocks_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "This is update!";
        }

        /// <summary>
        /// Update list box automatically whenever there is a change  
        /// in the record file 
        /// </summary>
        private void UpdateListBox()
        {
            List<KBStock> kbStocks = KBStock.KBGetStocks();
            kbStocks = kbStocks.OrderBy(a => a.Name).ToList();
            lstStocks.DisplayMember = "Name";
            lstStocks.ValueMember = "StockId";
            lstStocks.DataSource = kbStocks;
        }

        /// <summary>
        /// Fill in the input text with the values from the list box selected
        /// </summary>
        private void PopulateInputsWithSelectedList()
        {
            try
            {
                KBStock kbStock =
                    KBStock.KBGetByStockId(
                        int.Parse(lstStocks.SelectedValue.ToString()));
                txtStockId.Text = kbStock.StockId.ToString();
                txtName.Text = kbStock.Name;
                txtDescription.Text = kbStock.Description;
                txtPrice.Text = kbStock.Price.ToString();
                txtMinutes.Text = kbStock.Minutes.ToString();
                chkIsProcedure.Checked = kbStock.IsProcedure;
            }
            catch (Exception)
            {
                txtMessages.Text += "Errors while loading: Please click any button";
            }
        }
    }
}
