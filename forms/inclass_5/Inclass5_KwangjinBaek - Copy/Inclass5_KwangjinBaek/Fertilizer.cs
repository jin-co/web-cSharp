using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass5_KwangjinBaek
{
    /// <summary>
    /// This class validates the input and if there is no 
    /// error stores the data onto a file
    /// </summary>
    class Fertilizer
    {
        #region Properties
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime Start { get; set; }
        #endregion

        #region Constructor
        public Fertilizer()
        {

        }

        #endregion

        #region Variables
        string fileName = "inclass.txt";
        StreamReader reader;
        StreamWriter writer;
        #endregion

        #region methods (save, add)
        /// <summary>
        /// Check if file exists
        /// Check if there is any invalidity in the input
        /// If no problem found add the record to file
        /// </summary>
        public void Save()
        {
            CheckFile();
            Edit();
            Add();
        }

        /// <summary>
        /// write the properties onto file
        /// </summary>
        private void Add()
        {
            try
            {
                using(writer = new StreamWriter(fileName, append: true))
                {
                    writer.WriteLine(ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while saving:\t" + ex.Message);
            }
        }
        #endregion

        #region Utility Methods
        /// <summary>
        /// Override ToString method with properties
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name}\t" +
                $"{Password}\t" +
                $"{Start}";
        }

        /// <summary>
        /// Parse input data back to object
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        private Fertilizer Parse(string record)
        {
            Fertilizer fertilizer = new Fertilizer();
            string[] fields = record.Split('\t');
            fertilizer.Name = fields[0];
            fertilizer.Password = fields[1];
            fertilizer.Start = Convert.ToDateTime(fields[2]);
            return fertilizer;
        }

        /// <summary>
        /// Check if the file exists, if not create one
        /// </summary>
        private void CheckFile()
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Dispose();
            }
        }

        /// <summary>
        /// Check if name is empty 
        /// Check if password is 6 characters with at least one 
        /// letter, digit, and a punctuation containing
        /// Check if the date is not in the future
        /// If not valid for any of the above add errors
        /// </summary>
        private void Edit()
        {
            string errors = "";
            bool isLetter = false, isDigit = false, isPuctuation = false;
            TrimString();

            if (String.IsNullOrWhiteSpace(this.Name))
            {
                errors += "Name: Required\n";
            }

            if (this.Password.Length < 6)
            {
                errors += "Password: Must be 6 characters or more\n";
            }
            else
            {
                char[] words = this.Password.ToCharArray();
                foreach (var word in words)
                {
                    if (char.IsLetter(word))
                    {
                        isLetter = true;
                    }
                    if (char.IsDigit(word))
                    {
                        isDigit = true;
                    }
                    if (char.IsPunctuation(word))
                    {
                        isPuctuation = true;
                    }
                }
                if (!isLetter || !isDigit || !isPuctuation)
                {
                    errors += "Password: Must Contain a letter, digit and punctuation\n";
                }
            }

            if (this.Start > DateTime.Now)
            {
                errors += "Date: Cannot be in the future\n";
            }

            if (errors != "")
            {
                throw new Exception(errors);
            }
        }

        // Convert null to empty string and trim
        private void TrimString()
        {
            this.Name = (this.Name + " ").Trim();
            this.Password = (this.Password + " ").Trim();
        }
        #endregion
    }
}
