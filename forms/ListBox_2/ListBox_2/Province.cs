using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Province
    {
        #region constructors
        public Province()
        {

        }

        public Province(string provinceCode, string name)
        {

        }
        #endregion

        #region using private variables for properties -> old not used much
        //// properties by variables
        //private string provinceCode, name, taxCode;
        //private double taxRare;
        //private bool includesFederalTax = false;

        //// getter method
        //public string GetName()
        //{
        //    return name;
        //}

        //// setter method
        //public void SetName(string value)
        //{
        //    name = value;
        //}
        #endregion

        #region properties
        public string CountryCode { get; set; }
        public string ProvinceCode { get; set; }
        public string Name { get; set; }
        public string TaxCode { get; set; }
        public double TaxRate { get; set; }
        public bool IncludesFederalTax { get; set; }
        public string FirstLetterOfPostalCode { get; set; }
        #endregion

        #region variables
        static string record, fileName = "Province.txt"; 
        string archive = "archive.txt";
        static StreamWriter writer;
        static StreamReader reader;
        bool isAdd = false, found = false;
        #endregion

        #region Get methods
        /// <summary>
        /// get all province
        /// </summary>
        /// <returns></returns>
        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>();
            using (reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    record = reader.ReadLine();
                    provinces.Add(Parse(record));
                }
            }
            return provinces;
        }
        #endregion

        /// <summary>
        /// get the province record for the given province code
        /// null if not found
        /// </summary>
        /// <param name="provinceCode"></param>
        /// <returns></returns>
        public static Province GetProvince(string provinceCode)
        {
            Province province = null;
            using(reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    record = reader.ReadLine();
                    if (record.StartsWith(provinceCode + "\r"))
                    {
                        province = Parse(record);
                    }
                }
            }
            return province;
        }

        #region add, update, delete 
        /// <summary>
        /// add a new province record to file, if it passes edits
        /// </summary>
        public void Add()
        {
            isAdd = true;
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
                throw new Exception(ex.Message);  // when I use separate class exception is the only way to talk to the users
            }
        }

        // delete the record with the given key
        public void Delete(string provinceCode)
        {
            try
            {
                if (File.Exists(archive))
                {
                    File.Delete(archive);
                }
                File.Move(fileName, archive);
            }
            catch (Exception ex)
            {
                throw new Exception("problems creating the archive file: " + ex.Message);
            }

            try
            {
                using (reader = new StreamReader(archive))
                {
                    found = false;
                    using (writer = new StreamWriter(fileName, append: false)) // actually, it is redundant as we are using move not copy
                    {
                        while (reader.EndOfStream == true)
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
                }
                if (!found)
                {
                    throw new Exception($"Record key not found: '{provinceCode}");
                }
            }
            catch (Exception ex)
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                File.Move(archive, fileName);
                throw new Exception("Delete failed, file restored: " + ex.Message);
            }
                    }
        private void Edit()
        {
            string errors = "";


            if (errors != "")
            {
                throw new Exception(errors);
            }
        }
        #endregion

        #region
        /// <summary>
        /// convert the properties of this object into
        /// a single string, for storing to a text file
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{ProvinceCode}\r" +
                $"{Name}\r" +
                $"{CountryCode}\r" +
                $"{TaxCode}\r" +
                $"{TaxRate}\r" +
                $"{IncludesFederalTax}\r" +
                $"{FirstLetterOfPostalCode}";
        }

        /// <summary>
        /// parse a string back into the properties of a province object
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Province Parse(string input)
        {
            Province province = new Province();
            string[] fields = input.Split('\r');
            province.ProvinceCode = fields[0];
            province.Name = fields[1];
            province.CountryCode = fields[2];
            province.TaxCode = fields[3];
            province.TaxRate = Convert.ToDouble(fields[4]);
            province.IncludesFederalTax = Convert.ToBoolean(fields[5]);
            province.FirstLetterOfPostalCode = fields[6];

            //Province province = new Province()
            //{
            //    ProvinceCode = fields[0],
            //    Name = fields[1],
            //    CountryCode = fields[2],
            //    TaxCode = fields[3],
            //    TaxRate = Convert.ToDouble(fields[4]),
            //    IncludesFederalTax = Convert.ToBoolean(fields[5]),
            //    FirstLetterOfPostalCode = fields[6]
            //};    

            return province;
        }
        #endregion

    }
}
