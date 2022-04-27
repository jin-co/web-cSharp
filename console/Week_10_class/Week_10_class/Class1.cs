using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_class
{
    class Class1
    {
        #region properties
        public string ProvinceCode { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string TaxCode { get; set; }
        public double TaxRate { get; set; }
        public bool IncludesFederalTax { get; set; }
        public string FirstPostalLetters { get; set; }

        #endregion
        #region constructors
        #endregion

        #region variables
        static StreamReader reader;
        static StreamWriter writer;
        static string fileName = "province.txt", archive = "archive.txt";
        string record;
        bool isAdd = false;
        #endregion

        #region get methods 
        /// <summary>
        /// get a List of all provinces on file
        /// </summary>
        public static List<Form1> GetProvinces()
        {
            List<Form1> provinces = new List<Form1>(13);
            
        }

        public static Form1 GetProvinceByCode(string provinceCode)
        {
            Form1 form1 = null;
            using (reader = new StreamReader(fileName))
            {
                while (true)
                {
                    string record = reader.ReadLine();
                    if (record.StartsWith(provinceCode + "\r"))
                    {
                        form1 = Parse(record);
                        break;
                    }
                }
            }
            return form1;
        }
        #endregion

        #region insert, update and delete methods
        public void Insert()
        {
            Edit();
            try
            {
                using (writer = new StreamWriter(fileName, append: true))
                {
                    writer.WriteLine(ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception trying to add new record:\n" + ex.Message);
            }
        }

        public void Delete(string provinceCode)
        {
            string record = "";
            bool found = false;
            try
            {
                if (File.Exists(archive))
                {
                    File.Delete(archive);
                }
                File.Move(fileName, archive);
                using(reader = new StreamReader(archive))
                {
                    using(writer = new StreamWriter(fileName, append: false))
                    {
                        record = reader.ReadLine();
                        if (record.StartsWith(provinceCode + "\r"))
                        {
                            found = true;
                        }
                        else
                        {
                            writer.WriteLine(record);
                        }
                    }
                }
                if (!found)
                {
                    throw new Exception($"province code not on file: '{provinceCode}'");

                }
                else
                {
                    File.Delete(archive);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Exception deleting province: " +
                    ex.Message);
            }
        }
        #endregion
        #region utilities like tostring, pars, edit
        public override string ToString()
        {
            return $"{ProvinceCode}\r" +
                $"{Name}\r{CountryCode}" +
                $"{TaxCode}\r{TaxRate}\r" +
                $"{IncludesFederalTax}" +
                $"{FirstPostalLetters}";
        }


        /// <summary>
        /// edit the input before deciding to write to file
        /// </summary>
        private void Edit()
        {
            string errors = "";
            ProvinceCode = (ProvinceCode + "").Trim().ToUpper();
            Name = (Name + "").Trim();

            if (ProvinceCode == "")
            {
                errors += "province Code is required\n";
            }
            Form1 form = GetProvinceByCode(ProvinceCode);
            if (isAdd && form != null )
            {
                errors += "province code is already on file";
            }
            else if (!isAdd && form == null)
            {
                errors += "province code is not on file";
            }
            if (errors != "")
            {
                throw new Exception(errors);
            }
        }

        /// <summary>
        ///  
        ///
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Form1 Parse(string input)
        {
            string[] fields = input.Split('\r');
            Form1 form1 = new Form1()
            {
                ProvinceCode = fields[0],
                ProvinceCode = fields[1],
                ProvinceCode = fields[2],
                ProvinceCode = fields[3],
                TaxRate = fields[4],
                TaxRate = fields[5],
                TaxRate = fields[6],

            };
            return form1;
        }
        #endregion
    }
}
