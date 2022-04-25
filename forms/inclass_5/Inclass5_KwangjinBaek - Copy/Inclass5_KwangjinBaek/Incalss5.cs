using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inclass5_KwangjinBaek
{
    // Inclass 5 written by Kwangjin Baek 22. Apr. 2021.
    // this application stores data from user input to a file
    // if the input passes the validations
    public partial class Incalss5 : Form
    {
        List<string> words = new List<string>();
        public Incalss5()
        {
            InitializeComponent();
        }

        // 
        private void btnRun_Click(object sender, EventArgs e)
        {
            Fertilizer fertilizer = new Fertilizer();
            fertilizer.Name = txtName.Text;
            fertilizer.Password = txtPassword.Text;
            fertilizer.Start = datStartDate.Value;
            try
            {
                fertilizer.Save();
                rtbMessage.Text = "Record saved";
            }
            catch (Exception ex)
            {
                rtbMessage.Text = ex.Message;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            words.Add(txtInput.Text);
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            rtbMessage.Text = "";
            string result = "";
            List<string> afterRemovingPunctuations = new List<string>();
            List<char> eachWord = new List<char>();
            for (int i = 0; i < words.Count; i++)
            {
                eachWord = words[i].ToList();
                for (int j = 0; j < eachWord.Count; j++)
                {
                    if (char.IsPunctuation(eachWord[j]))
                    {
                        eachWord.Remove(eachWord[j]);
                    }
                }
                string wordWithoutPunction = new string(eachWord.ToArray());
                afterRemovingPunctuations.Add(wordWithoutPunction);
            }
            string[] wordToArray = new string[afterRemovingPunctuations.Count];
            afterRemovingPunctuations.Reverse();
            wordToArray = afterRemovingPunctuations.ToArray();
            for (int i = 0; i < wordToArray.Length; i++)
            {
                result += i + " - " + wordToArray[i] + "\n";
            }
            rtbMessage.Text = result;
        }
    }
}
