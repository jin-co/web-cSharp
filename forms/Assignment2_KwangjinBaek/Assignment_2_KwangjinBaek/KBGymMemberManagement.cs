using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_KwangjinBaek
{
    // Code written by Kwangjin Baek #8707943
    /* this application is a form that allows user input 
     * then check all the fields are in right format 
     * shows error messages if one or more of them are
     * in wrong format */ 
    public partial class KBGymMemberManagement : Form
    {
        string errorMessage = "";
        string[] errorMessages = new string[] {
        "Please Enter Your Full Name",  //0
        "Please Enter Both First And Last Name",  //1
        "Please Enter At Least One of Your Phone Numbers",  //2
        "Please Enter Your Member Goal",  //3
        "Please Enter Your Member Code",  //4
        "Please Enter Your Postal Code",  //5
        "Please Enter Your Address, Town and Province Code",  //6
        "Phone Number Error: Please Enter 000-000-0000 or 000.000.0000",  //7
        "Email Error: Please Enter Valid Email",  //8
        "Please Enter Valid Join Date 0000 00 00 or 0000/00/00",  //9
        "Join Date Error: Date Can Not Be In The Future",  //10 
        "Member Code Error: Please Enter 5 Digits and 4 Capital letters",  //11
        "Mailing Address Error: Please Enter At Least 3 letters",  //12
        "Town Error: Please Enter At Least 3 letters",  //13
        "Province Code Error: Please Enter 2 letters",  //14
        "No E-mail: Please Enter Province Code And Town",  //15
        "Postal Code Error: Please Enter _[_]#[_/#] #__",  //16
        };

        public KBGymMemberManagement()
        {
            InitializeComponent();
        }

        // close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // clear all the text box
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }

        // clear all the text before start
        // validate input values for each field
        // edit input to right format
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorMessage = "";
            txtErrorMessage.Text = "";

            /// postal code validation
            // check if the field is empty
            // validate the input code
            errorMessage = AddErrorMessageIfRequiredFieldIsEmpty(
                errorMessages, 5, txtPostalCode) + errorMessage;

            if (txtPostalCode.Text != "")
            {
                // check if it is a valid postal code
                // return formatted postal code if it is valid
                // add error and set focus if it is not valid
                string postalCode = txtPostalCode.Text.Trim();
                if (KBValidation.KBUKPostalValidation(ref postalCode))
                {
                    txtPostalCode.Text = postalCode;
                }
                else
                {
                    errorMessage = errorMessages[16] + "\n" + errorMessage;
                    txtPostalCode.Focus();
                }
            }

            // check if email is given
            // if not ask the user to add province code and town
            if (txtEmail.Text == "")
            {
                if (txtProvinceCode.Text == "" || txtTown.Text == "")
                {
                    errorMessage = errorMessages[15] + "\n" + errorMessage;
                    if (txtTown.Text == "")
	                {
                        txtTown.Focus();
	                }
                    else
	                {
                        txtProvinceCode.Focus();
	                }
                }
            }

            /// province code
            // check if it is exact two letters (only letters)
            // add error and set focus if it is in wrong format
            if (txtProvinceCode.Text != "")
            {
                Regex pattern = new Regex(@"^[a-zA-Z][a-zA-Z]$");
                if (!pattern.IsMatch(txtProvinceCode.Text))
                {
                    errorMessage = errorMessages[14] + "\n" + errorMessage;
                    txtProvinceCode.Focus();
                }
                txtProvinceCode.Text = txtProvinceCode.Text.Trim().ToUpper();
            }

            /// town validation
            // check if it is more than three letters
            // capitalize the letters
            if (txtTown.Text != "")
            {
                AreLettersMoreThanThree(txtTown, 13);
                txtTown.Text = KBValidation.KBCapitalize(txtTown.Text);
            }

            /// mailing address validation
            // check if it is more than three letters
            if (txtMailingAddress.Text != "")
            {
                AreLettersMoreThanThree(txtMailingAddress, 12);
            }
            // capitalize the text
            txtMailingAddress.Text = KBValidation.KBCapitalize(txtMailingAddress.Text);

            /// member code validation - required field
            // check if the field is empty
            errorMessage = AddErrorMessageIfRequiredFieldIsEmpty(
                errorMessages, 4, txtMemberCode) + errorMessage;

            if (txtMemberCode.Text != "")
            {
                // add error and set focus if member code is in wrong format
                txtMemberCode.Text = txtMemberCode.Text.Trim();
                if (!KBValidation.KBMemberCodeValidation(txtMemberCode.Text))
                {
                    errorMessage = errorMessages[11] + "\n" + errorMessage;
                    txtMemberCode.Focus();
                }
            }

            /// join date validation
            if (txtDateJoined.Text != "")
            {
                // add error and set focus if input is not in convertible format
                // check if input date is in the future if so add error ans set focus
                // convert the input to '2000 jan 10' format if there is no error
                DateTime dateConverted = DateTime.Now;
                if (DateTime.TryParse(txtDateJoined.Text, out dateConverted))
                {
                    if (DateTime.Now.Subtract(dateConverted).Days <= 0)
                    {
                        errorMessage = errorMessages[10] + "\n" + errorMessage;
                        txtDateJoined.Focus();
                    }
                    else
                    {
                        txtDateJoined.Text = dateConverted.ToString("yyyy MMM d");
                    }
                }

                else
                {
                    errorMessage = errorMessages[9] + "\n" + errorMessage;
                    txtDateJoined.Focus();
                }
            }

            /// email validation
            // check the email format
            if (txtEmail.Text != "")
            {
                IsEmailValid(txtEmail.Text);
            }

            /// phone number validation
            AreAllPhoneNumbersEmpty(txtCellPhone,
                txtHomePhone, txtWorkPhone);

            IsPhoneNumberValid(ref txtCellPhone);
            IsPhoneNumberValid(ref txtHomePhone);
            IsPhoneNumberValid(ref txtWorkPhone);

            /// member goal validation - required field
            // check if the field is empty
            errorMessage = AddErrorMessageIfRequiredFieldIsEmpty(
                errorMessages, 3, txtMemberGoal) + errorMessage;

            if (txtMemberGoal.Text != "")
            {
                string result = "";
                txtMemberGoal.Text = KBValidation.KBCapitalize(txtMemberGoal.Text);

                // delete all the punctuation except for period
                Regex punctuation = new Regex(@"\p{P}");
                char[] characters = txtMemberGoal.Text.ToCharArray();

                foreach (var character in characters)
                {
                    if (character == '.')
                    {
                        result += '.';
                    }
                    else
                    {
                        result += punctuation.Replace(character.ToString(), "");
                    }
                }
                txtMemberGoal.Text = result;
            }

            /// name validation - required field
            // check if the field is empty            
            errorMessage = AddErrorMessageIfRequiredFieldIsEmpty(
                errorMessages, 0, txtFullName) + errorMessage;

            // add error and set focus if the field is empty
            // capitalize the text if valid
            if (!IsRequiredInputEmpty(txtFullName.Text) &&
                !txtFullName.Text.Trim().Contains(" "))
            {
                errorMessage = errorMessages[1] + "\n" + errorMessage;
                txtFullName.Focus();
            }
            else
            {
                txtFullName.Text = KBValidation.KBCapitalize(txtFullName.Text);
            }

            // display the error message
            txtErrorMessage.Text = errorMessage;
        }

        // fill in member goal field for a test
        private void btnPreFill_Click(object sender, EventArgs e)
        {
            txtMemberGoal.Text = "To Run 126 mileS; in 2 hours. Perform 300 " +
                "situps, and Squat 100 pOUNDS, by January of 2021.";
        }

        // show contact information
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Kwangjin Baek\n" +
                "E-mail: lilijk@hanmail.net", "Contact Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // clear all the text box if they are not blank
        private void ClearTextBoxes(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                TextBox textBox = control as TextBox;
                if (textBox != null)
                {
                    textBox.Clear();
                }
            }
        }

        // return error message and set focus if it is empty for required field
        private string AddErrorMessageIfRequiredFieldIsEmpty(
            string[] errorMessages, int number, TextBox textBox)
        {
            if (IsRequiredInputEmpty(textBox.Text))
            {
                textBox.Focus();
                return errorMessages[number] + "\n";
            }
            else
            {
                return null;
            }
        }

        // check if the required field is empty
        // return true if it is empty
        private bool IsRequiredInputEmpty(string input)
        {
            Regex whiteSpace = new Regex(@"^[\s\b]");
            if (String.IsNullOrEmpty(input) || whiteSpace.IsMatch(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // check if all phone number fields are empty
        // if it is add error and set focus
        private void AreAllPhoneNumbersEmpty(
            TextBox textBox1, TextBox textBox2, TextBox textBox3)
        {
            if (IsRequiredInputEmpty(textBox1.Text) &&
                IsRequiredInputEmpty(textBox2.Text) &&
                IsRequiredInputEmpty(textBox3.Text))
            {
                errorMessage = errorMessages[2] + "\n" + errorMessage;
                txtCellPhone.Focus();
            }
        }

        // check if a given phone number is in valid format
        // add an error message and set focus if it is not valid
        private void IsPhoneNumberValid(ref TextBox textBox)
        {
            textBox.Text = textBox.Text.Trim();
            if (textBox.Text != "")
            {
                if (!KBValidation.KBPhoneNumberValidation(textBox.Text))
                {
                    errorMessage = errorMessages[7] + "\n" + errorMessage;
                    textBox.Focus();
                }
            }
        }

        // check if a given email is valid
        // add error and set focus if it is not valid
        private void IsEmailValid(string emailInput)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(emailInput);
                txtEmail.Text = txtEmail.Text.Trim().ToLower();
            }
            catch (FormatException)
            {
                errorMessage = errorMessages[8] + "\n" + errorMessage;
                txtEmail.Focus();
            }
        }

        // check how many characters are in the input
        // add error and set focus if there are less than 3 letters
        private void AreLettersMoreThanThree(TextBox textBox, int fieldIndex)
        {
            int count = 0;
            string word = textBox.Text.Trim();
            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    count++;
                }
            }
            if (count < 3)
            {
                errorMessage = errorMessages[fieldIndex] + "\n" + errorMessage;
                textBox.Focus();
            }
        }
    }
}
