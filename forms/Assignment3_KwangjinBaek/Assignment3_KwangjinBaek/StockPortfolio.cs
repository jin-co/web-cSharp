using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_KwangjinBaek
{
    // Assignment 3 Written by Kwangjin Baek / #8707943
    // this application is stock portfolio record tracker
    // that allows users to add, update or delete transaction records
    // grid view is synchronized with the record so that users can see
    // the current records on the file
    public partial class StockPortfolio : Form
    {
        string fileName = "", record = "", transactionType = "", note = "";
        double totalAssetValue = 0, totalTransactionValue = 0,
               sharePrice = 0, commission = 0;
        int count = 0, transactionId = 0, numberOfShare = 0;
        StreamWriter writer;
        StreamReader reader;
        public StockPortfolio()
        {
            InitializeComponent();
        }

        // on load, disable all the buttons except for the create/open file
        private void StockPortfolio_Load(object sender, EventArgs e)
        {
            btnGetNewId.Enabled = false;
            btnAddUpdate.Enabled = false;
            btnClear.Enabled = false;
            btnDeleteTransaction.Enabled = false;
            btnReload.Enabled = false;
            btnEmptyFile.Enabled = false;
        }

        // check if input file exists
        // if exists show the record
        // if not create a file
        // enable all the buttons so the data can be add or manipulated
        private void btnCreateOpenFile_Click(object sender, EventArgs e)
        {
            btnGetNewId.Enabled = true;
            btnAddUpdate.Enabled = true;
            btnClear.Enabled = true;
            btnDeleteTransaction.Enabled = true;
            btnReload.Enabled = true;
            btnEmptyFile.Enabled = true;
            txtMessage.Text = "";
            try
            {
                fileName = txtFileNameInput.Text;
                if (Directory.Exists(fileName))
                {
                    Directory.CreateDirectory(fileName);
                }
                if (File.Exists(txtFileNameInput.Text))
                {
                    UpdateGridView();
                }

                else
                {
                    FileStream newFile = File.Create(fileName);
                    newFile.Dispose();
                    CreateRecord();
                    txtMessage.Text = "New file created";
                }
            }
            catch (ArgumentException ex)
            {
                txtMessage.Text = ex.Message;
            }
            catch (FileNotFoundException ex)
            {
                txtMessage.Text = ex.Message;
            }
            catch (DirectoryNotFoundException ex)
            {
                txtMessage.Text = ex.Message;
            }
            catch (IOException ex)
            {
                txtMessage.Text = ex.Message;
            }
            catch (Exception ex)
            {
                txtMessage.Text = ex.Message;
            }
        }

        // delete transaction
        // check if the entered transaction id exists on the file
        // update grid view accordingly
        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            List<string> container = new List<string>();
            container = CreateTemporaryRecord();

            if (DoesRecordExist(container, txtTranscationIdDelete.Text))
            {
                File.Delete(fileName);
                try
                {
                    for (int j = 0; j < container.Count; j++)
                    {
                        using (writer = new StreamWriter(fileName, append: true))
                        {
                            if (count == j)
                            {
                                continue;
                            }
                            else
                            {
                                writer.WriteLine(container[j]);
                                txtMessage.Text = "Record Deleted";
                            }
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    txtMessage.Text = ex.Message;
                }
                catch (FileNotFoundException ex)
                {
                    txtMessage.Text = ex.Message;
                }
                catch (DirectoryNotFoundException ex)
                {
                    txtMessage.Text = ex.Message;
                }
                catch (IOException ex)
                {
                    txtMessage.Text = ex.Message;
                }
                catch (Exception ex)
                {
                    txtMessage.Text = ex.Message;
                }
            }

            else
            {
                txtMessage.Text = "Record does not exist";
            }
            UpdateGridView();
        }

        // refreshes the grid view to the most current data
        private void btnReload_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            gridView.Refresh();
            UpdateGridView();
        }

        // close the form 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // delete all the record from the file
        // update grid view accordingly
        private void btnEmptyFile_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            txtTranscationIdDelete.Text = "";
            File.WriteAllText(fileName, string.Empty);
            UpdateGridView();
        }

        // on double click on any row on grid view
        // fill all the input fields with the record from the row chosen
        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMessage.Text = "";
            txtTranscationIdDelete.Text = "";
            List<string> container = new List<string>();
            container = CreateTemporaryRecord();

            string[] recordChosen = new string[10];
            recordChosen = container[e.RowIndex].Split('\t');
            txtTransactionIdGetNew.Text = recordChosen[0];
            txtTickerSymbol.Text = recordChosen[1];
            txtCompany.Text = recordChosen[2];
            if (recordChosen[3] == "BUY")
            {
                radBuy.Select();
            }
            else
            {
                radSell.Select();
            }
            datDate.Value = Convert.ToDateTime(recordChosen[4]);
            txtNotes.Text = recordChosen[10].Replace("</br>", "\n");
            txtSharePrice.Text = recordChosen[5].Substring(1);
            txtNumberOfShares.Text = recordChosen[6];
            txtCommission.Text = recordChosen[7].Substring(1);
        }

        // produce a new unique id automatically
        private void btnGetNewId_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            List<string> container = new List<string>();
            container = CreateTemporaryRecord();

            List<int> currentIdList = new List<int>();
            for (int i = 0; i < container.Count; i++)
            {
                currentIdList.Add(int.Parse(container[i].Substring(0, 
                    container[i].IndexOf("\t"))));
            }

            for (int k = 1; k < 10000; k++)
            {
                if (!currentIdList.Contains(k))
                {
                    txtTransactionIdGetNew.Text = k.ToString();
                    break;
                }
            }
        }

        // clear all the data written on the transaction form
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            txtTranscationIdDelete.Text = "";
            txtTransactionIdGetNew.Text = "";
            txtTickerSymbol.Text = "";
            txtCompany.Text = "";
            radBuy.Select();
            datDate.Value = DateTime.Now;
            txtNotes.Text = "";
            txtSharePrice.Text = "";
            txtNumberOfShares.Text = "";
            txtCommission.Text = "";
        }

        // validate each field
        // show error message if there are errors
        // when there is no error check if input transaction id exists
        // if exists update the data
        // if not add a new record
        // update grid view accordingly
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            /*------------------------- validations ------------------------*/
            // commission validation
            // check if the field is empty
            // check if the input is digit. if not, ask users to enter digit
            // if error occurs, set focus
            if (!double.TryParse(txtCommission.Text, out commission))
            {
                txtMessage.Text = "Commission: Required and must be digits\n" +
                txtMessage.Text;
                txtCommission.Focus();
            }

            // number of share validation
            // check if the field is empty
            // check if the input is digit. 
            // if it is empty or not a digit add error message and set focus
            if (!int.TryParse(txtNumberOfShares.Text, out numberOfShare))
            {
                txtMessage.Text = "Number of Share: Required and must be digits\n" +
                txtMessage.Text;
                txtNumberOfShares.Focus();
            }

            // share price validation 
            // check if the field is empty
            // add error and set focus if the input price is less than 1 or empty
            if (double.TryParse(txtSharePrice.Text, out sharePrice))
            {
                if (sharePrice <= 0)
                {
                    txtMessage.Text = "Share price: must be greater than 0\n" +
                        txtMessage.Text;
                    txtSharePrice.Focus();
                }
            }
            else
            {
                txtMessage.Text = "Share price: Required and must be digits\n" +
                    txtMessage.Text;
                txtSharePrice.Focus();
            }
            
            // note validation
            // check if the field is empty
            CheckIfEmpty(txtNotes, "Notes");

            // date validation 
            // add error and set focus if date is in the future
            DateTime inputDate = datDate.Value;
            int dateSpan = DateTime.Today.Subtract(inputDate).Days;
            if (dateSpan < 0)
            {
                txtMessage.Text = "Date can not be in the future\n" + 
                    txtMessage.Text;
                datDate.Focus();
            }

            // company validation
            // check if the field is empty
            CheckIfEmpty(txtCompany, "Company name");

            // ticker symbol validation
            // check if the field is empty
            CheckIfEmpty(txtTickerSymbol, "Ticker symbol");

            // transaction validation
            // add error and set focus if the input ID is less than 1 or empty
            if (int.TryParse(txtTransactionIdGetNew.Text, out transactionId))
            {
                if (transactionId <= 0)
                {
                    txtMessage.Text = "Transaction ID: must be greater than 0\n" + 
                        txtMessage.Text;
                    txtTransactionIdGetNew.Focus();
                }
            }
            else
            {
                txtMessage.Text = "Transaction ID: Required and must be digits\n" + 
                    txtMessage.Text;
                txtTransactionIdGetNew.Focus();
            }

            /*------------------ adding,updating a record ------------------*/
            // check if the transaction id exists
            // if it does update, if not add a new record
            // update grid view accordingly
            List<string> container = new List<string>();
            container = CreateTemporaryRecord();

            if (txtMessage.Text == "")
            {
                try
                {
                    if (DoesRecordExist(container, txtTransactionIdGetNew.Text))
                    {
                        container[count] = CreateRecord();
                        File.Delete(fileName);
                        for (int i = 0; i < container.Count; i++)
                        {
                            using (writer = new StreamWriter(fileName, append: true))
                            {
                                writer.WriteLine(container[i]);
                                txtMessage.Text = "Record Updated";
                            }
                        }
                    }

                    else
                    {
                        record = CreateRecord();
                        using (writer = new StreamWriter(fileName, append: true))
                        {
                            writer.WriteLine(record);
                            txtMessage.Text = "Record Added";
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    txtMessage.Text = ex.Message;
                }
                catch (FileNotFoundException ex)
                {
                    txtMessage.Text = ex.Message;
                }
                catch (DirectoryNotFoundException ex)
                {
                    txtMessage.Text = ex.Message;
                }
                catch (IOException ex)
                {
                    txtMessage.Text = ex.Message;
                }
                catch (Exception ex)
                {
                    txtMessage.Text = ex.Message;
                }
            }
            UpdateGridView();
        }

        // create temporary record collection for manipulations
        // (to add new record, update and delete)
        private List<string> CreateTemporaryRecord()
        {
            List<string> container = new List<string>();
            try
            {
                using (reader = new StreamReader(path: fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        container.Add(reader.ReadLine());
                        string[] fields = record.Split('\t');
                    }
                }
            }
            catch (ArgumentException ex)
            {
                txtMessage.Text = ex.Message;
            }
            catch (FileNotFoundException ex)
            {
                txtMessage.Text = ex.Message;
            }
            catch (DirectoryNotFoundException ex)
            {
                txtMessage.Text = ex.Message;
            }
            catch (IOException ex)
            {
                txtMessage.Text = ex.Message;
            }
            catch (Exception ex)
            {
                txtMessage.Text = ex.Message;
            }
            return container;
        }

        // create a record for each row
        // trim record before storing
        private string CreateRecord()
        {
            totalAssetValue = sharePrice * numberOfShare;
            totalTransactionValue = totalAssetValue + commission;
            note = txtNotes.Text.Replace("\n", "</br>");
            if (radBuy.Checked)
            {
                transactionType = radBuy.Text;
            }
            else
            {
                transactionType = radSell.Text;
            }
            record = $"{txtTransactionIdGetNew.Text.Trim()}\t" +
                $"{txtTickerSymbol.Text.ToUpper().Trim()}\t" +
                $"{Capitalize(txtCompany.Text.Trim())}\t" +
                $"{transactionType.ToUpper()}\t" +
                $"{datDate.Value.ToString()}\t" +
                $"{sharePrice.ToString("c")}\t" +
                $"{txtNumberOfShares.Text.Trim()}\t" +
                $"{commission.ToString("c")}\t{totalAssetValue:c}\t" +
                $"{totalTransactionValue.ToString("c")}\t" +
                $"{note}";
            return record;
        }

        // clear previous records written on grid view
        // write records from the file onto the grid view
        private void UpdateGridView()
        {
            gridView.Columns.Clear();
            gridView.ColumnCount = 10;

            gridView.Columns[0].Name = "Transaction ID";
            gridView.Columns[1].Name = "Ticker Symbol";
            gridView.Columns[2].Name = "Company";
            gridView.Columns[3].Name = "Transaction Type";
            gridView.Columns[4].Name = "Date";
            gridView.Columns[5].Name = "Share Price";
            gridView.Columns[6].Name = "# Shares";
            gridView.Columns[7].Name = "Commission";
            gridView.Columns[8].Name = "Total Asset Value";
            gridView.Columns[9].Name = "Total Transaction Value";

            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        string[] fields = record.Split('\t');
                        gridView.Rows.Add(fields);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                txtMessage.Text = ex.Message;
            }
            catch (FileNotFoundException ex)
            {
                txtMessage.Text = ex.Message;
            }
            catch (DirectoryNotFoundException ex)
            {
                txtMessage.Text = ex.Message;
            }
            catch (IOException ex)
            {
                txtMessage.Text = ex.Message;
            }
            catch (Exception ex)
            {
                txtMessage.Text = ex.Message;
            }
        }

        // check if entered transaction ID exists
        // if so return true
        private bool DoesRecordExist(List<string> container, string fieldName)
        {
            if (!String.IsNullOrEmpty(fieldName) || !String.IsNullOrWhiteSpace(fieldName))
            {
                for (count = 0; count < container.Count; count++)
                {
                    if (fieldName.Trim() == container[count].Substring(0, container[count].IndexOf("\t")))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // check if the field is empty
        // if it is empty add error message and set focus
        private void CheckIfEmpty(Control field, string fieldName)
        {
            if (String.IsNullOrEmpty(field.Text) || String.IsNullOrWhiteSpace(field.Text))
            {
                txtMessage.Text = fieldName + ": Required\n" + txtMessage.Text;
                field.Focus();
            }
        }

        // capitalize words
        private string Capitalize(string fieldName)
        {
            string capitalized = "";
            string[] words = fieldName.Split(new string[] { " " },
                StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                capitalized += words[i].Substring(0, 1).ToUpper();
                capitalized += words[i].Substring(1).ToLower();
                capitalized += " ";
            }
            return capitalized.Trim();
        }
    }
}
