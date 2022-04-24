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
        "Country Error: Please Enter 2 letters",  //14
        "No E-mail: Please Enter Province Code And Town",  //15
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


        // validate input values for each field
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorMessage = "";
            txtErrorMessage.Text = "";

            // name validation
            errorMessage += AddErrorMessage(errorMessages, 0, txtFullName);
            if (!IsRequiredInputEmpty(txtFullName.Text) && 
                !txtFullName.Text.Trim().Contains(" "))
            {
                errorMessage += errorMessages[1] + "\n";
                txtFullName.Focus();
            }
            else
            {
                txtFullName.Text = KBValidation.KBCapitalize(txtFullName.Text);
            }

            // member goal validation
            errorMessage += AddErrorMessage(errorMessages, 3, txtMemberGoal);
            if (txtMemberGoal.Text != "")
            {
                string job = "";
                txtMemberGoal.Text = KBValidation.KBCapitalize(txtMemberGoal.Text);
                Regex punctuation = new Regex(@"\p{P}");
                char[] wor = txtMemberGoal.Text.ToCharArray();
                foreach (var item in wor)
                {
                    if (item == '.')
                    {
                        job += '.';
                    }
                    else
                    {
                        job += punctuation.Replace(item.ToString(), "");
                    }
                }
                txtMemberGoal.Text = job;
            }

            // phone number validation
            AreAllPhoneNumbersEmpty(txtCellPhone.Text, 
                txtHomePhone.Text, txtWorkPhone.Text);

            // email validation
            if (txtEmail.Text != "")
            {
                IsEmailValid(txtEmail.Text);
            }

            // join date validation
            if (txtDateJoined.Text != "")
            {
                if (IsDateInputRightFormat(txtDateJoined.Text))
                {
                    DateTime inputDate = Convert.ToDateTime(txtDateJoined.Text);
                    if (DateTime.Now.Subtract(inputDate).Days <= 0)
                    {
                        errorMessage += errorMessages[10] + "\n";
                    }
                    else
                    {
                        txtDateJoined.Text = inputDate.ToString("yyyy MMM d");
                    }
                }
                else
                {
                    errorMessage += errorMessages[9] + "\n";
                }
            }

            // member code validation
            errorMessage += AddErrorMessage(errorMessages, 4, txtMemberCode);
            if (txtMemberCode.Text != "")
            {
                if (!KBValidation.KBMemberCodeValidation(txtMemberCode.Text))
                {
                    errorMessage += errorMessages[11] + "\n";
                }
            }

            // mailing address validation
            if (txtMailingAddress.Text != "")
            {
                AreLettersMoreThanThree(txtMailingAddress.Text, 12);
            }
            txtMailingAddress.Text = KBValidation.KBCapitalize(txtMailingAddress.Text);

            // town validation

            txtTown.Text = KBValidation.KBCapitalize(txtTown.Text);

            // country validation
            if (txtCountry.Text != "")
            {
                Regex pattern = new Regex(@"^[a-zA-Z][a-zA-Z]$");
                if (!pattern.IsMatch(txtCountry.Text))
                {
                    errorMessage += errorMessages[14] + "\n";
                }
            }

            // province code
            if (txtProvinceCode.Text != "")
            {
                AreLettersMoreThanThree(txtTown.Text, 13);
            }
            txtProvinceCode.Text = txtProvinceCode.Text.ToUpper();

            // postal code validation
            errorMessage += AddErrorMessage(errorMessages, 5, txtPostalCode);
            if (txtPostalCode.Text != "")
            {
                string postalCode = txtPostalCode.Text;
                KBValidation.KBUKPostalValidation(ref postalCode);
                txtPostalCode.Text = postalCode;
            }

            /* add error message if province code or postal code are not given 
             * when there is no email input */
            if (txtEmail.Text == "")
            {
                if (txtProvinceCode.Text == "" || txtTown.Text == "")
                {
                    errorMessage += errorMessages[15] + "\n";
                }
            }





            txtErrorMessage.Text = errorMessage;
        }

        // fill in member goal field for a test
        private void btnPreFill_Click(object sender, EventArgs e)
        {
            txtMemberGoal.Text = "To Run 126 mileS; in 2 hours. Perform 300 " +
                "situps, and Squat 100 pOUNDS, by January of 2021.";
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

        // return error message if it is empty
        private string AddErrorMessage(string[] errorMessages, int number, TextBox textBox)
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

        // check if the field is empty
        private bool IsRequiredInputEmpty(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // check if all phone number fields are empty
        private void AreAllPhoneNumbersEmpty(string cellPhone, string homePhone, string workPhone)
        {
            if (IsRequiredInputEmpty(cellPhone) &&
                IsRequiredInputEmpty(homePhone) &&
                IsRequiredInputEmpty(workPhone))
            {
                errorMessage += errorMessages[2] + "\n";
            }
            else
            {
                IsPhoneNumberValid(cellPhone);
                IsPhoneNumberValid(homePhone);
                IsPhoneNumberValid(workPhone);
            }
        }

        // check if a given phone number is valid
        // add an error message if it is not valid
        private void IsPhoneNumberValid(string field)
        {
            if (field != "")
            {
                if (!KBValidation.KBPhoneNumberValidation(field))
                {
                    errorMessage += errorMessages[7] + "\n";
                }
            }
        }

        // check if a given email is valid
        // add an error message if it is not valid
        private void IsEmailValid(string emailInput)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(emailInput);
                txtEmail.Text = txtEmail.Text.ToLower();
            }
            catch (FormatException)
            {
                errorMessage += errorMessages[8] + "\n";
            }
        }

        // check if date input is in right format to convert to date
        private bool IsDateInputRightFormat(string dateInput)
        {
            Regex pattern = new Regex(@"\d{4}[ /]\d\d?[ /]\d\d?");
            if (pattern.IsMatch(dateInput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // check how many characters in the input
        // add error message if the total number is less than 3
        private void AreLettersMoreThanThree(string input, int fieldIndex)
        {
            int count = 0;
            string word = input.Trim();
            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    count++;
                }
            }
            if (count < 3)
            {
                errorMessage += errorMessages[fieldIndex] + "\n";
            }
        }
    }
}
