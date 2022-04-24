using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_KwangjinBaek_1.KBClasses
{
    /// <summary>
    /// class that manages stock items and services in a beauty shop.  
    /// such as eyebrow waxing, organizing products, like brushes, conditioners.  
    /// </summary>
    class KBStock
    {
        #region Properties
        public int StockId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Minutes { get; set; }
        public bool IsProcedure { get; set; }
        #endregion

        #region Variables
        static private string stockPath = "Stock.txt", record = "", 
            archive = "archive.txt";
        static StreamWriter writer;
        static StreamReader reader;
        string errorMessages = "";
        bool isNameOnTheRecord = false;
        #endregion

        #region Constructors
        public KBStock() { }

        public KBStock(string name)
        {
            Name = name;
        }
        #endregion

        /// <summary>
        /// when called return a string that
        /// concatenated the properties with delimiter
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{StockId}\t" +
                $"{Name}\t" +
                $"{Description}\t" +
                $"{Price}\t" +
                $"{Minutes}\t" +
                $"{IsProcedure}\t";
        }

        /// <summary>
        /// return object of a stock properties
        /// </summary>
        /// <returns></returns>
        public static KBStock KBParse(string input)
        {
            KBStock kbStock = new KBStock();
            string[] records = input.Split('\t');
            kbStock.StockId = Convert.ToInt32(records[0]);
            kbStock.Name = records[1];
            kbStock.Description = records[2];
            kbStock.Price = Convert.ToDouble(records[3]);
            kbStock.Minutes = Convert.ToInt32(records[4]);
            kbStock.IsProcedure = Convert.ToBoolean(records[5]);
            return kbStock;
        }

        /// <summary>
        /// return a list of stocks on file
        /// </summary>
        /// <returns></returns>
        public static List<KBStock> KBGetStocks()
        {
            List<KBStock> kbStocks = new List<KBStock>();
            try
            {
                using (reader = new StreamReader(stockPath))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        kbStocks.Add(KBParse(record));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errors while reading files: " + ex.Message);
            }
            return kbStocks;
        }

        /// <summary>
        /// return an object that matches input id
        /// if not found return null
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns></returns>
        public static KBStock KBGetByStockId(int stockId)
        {
            KBStock kbStock = null;
            try
            {
                using (reader = new StreamReader(stockPath))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        if (record.StartsWith(stockId + "\t"))
                        {
                            kbStock = KBParse(record);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errors while reading files: " + ex.Message);
            }
            return kbStock;
        }

        /// <summary>
        /// return every stock that contains input phrase
        /// either in name or description.
        /// return empty if nothing is found
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<KBStock> KBGetByDescription(string input)
        {
            List<KBStock> kbStock = new List<KBStock>();
            try
            {
                using (reader = new StreamReader(stockPath))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        if (record.Contains(input))
                        {
                            kbStock.Add(KBParse(record));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errors while reading files: " + ex.Message);
            }
            return kbStock;
        }

        /// <summary>
        /// If the current object passes all edits
        /// assign a unique StockId to the object and 
        /// add the record to the file
        /// </summary>
        public void KBAdd(KBStock kbStock)
        {
            errorMessages = "";
            KBEdit();
            CreateStockId();
            try
            {
                using (writer = new StreamWriter(stockPath, append: true))
                {
                    writer.WriteLine(ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errors while adding a record: " + ex.Message);
            }
        }

        /// <summary>
        /// Replace the current record 
        /// with the same StockId, if the updated record passes the edits
        /// </summary>
        public void KBUpdate(KBStock kBStock)
        {
            errorMessages = "";
            KBEdit();
            
            if (!isNameOnTheRecord)
            {
                errorMessages += "Stock name dose not exist";
            }

            if (errorMessages != "")
            {
                throw new Exception(errorMessages);
            }
            else
            {
                try
                {
                    CreateTemporaryRecord();
                    using (reader = new StreamReader(archive))
                    {
                        using (writer = new StreamWriter(stockPath, append: true))
                        {
                            while (!reader.EndOfStream)
                            {
                                record = reader.ReadLine();
                                if (record.StartsWith(this.StockId + "\t"))
                                {
                                    writer.WriteLine(ToString());
                                }
                                else
                                {
                                    writer.WriteLine(record);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    File.Delete(stockPath);
                    File.Copy(archive, stockPath);
                    throw new Exception("Delete failed, file restored: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Remove the record 
        /// with the given StockId from the file. 
        /// </summary>
        public static void KBDelete(string stockId)
        {
            CreateTemporaryRecord();
            try
            {
                using (reader = new StreamReader(archive))
                {
                    using (writer = new StreamWriter(stockPath, append: false))
                    {
                        while (!reader.EndOfStream)
                        {
                            record = reader.ReadLine();
                            if (record.StartsWith(stockId + "\t"))
                            {
                                continue;
                            }
                            else
                            {
                                writer.WriteLine(record);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.Delete(stockPath);
                File.Copy(archive, stockPath);
                throw new Exception("Delete failed, file restored: " + ex.Message);
            }
        }

        /// <summary>
        /// Create a temporary file for file update or delete
        /// </summary>
        private static void CreateTemporaryRecord()
        {
            try
            {
                File.Delete(archive);
                File.Move(stockPath, archive);
            }
            catch (Exception ex)
            {
                throw new Exception("Errors during back: " + ex.Message);
            }
        }

        /// <summary>
        /// Check if file exists. If not, create one
        /// </summary>
        public static void VerifyFile()
        {
            try
            {
                if (!File.Exists(stockPath))
                {
                    File.Create(stockPath).Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errors during file creation: " + ex.Message);
            }
        }

        /// <summary>
        /// Perform validations on the current object  
        /// If there are any errors or exception messages, 
        /// show them all at once in an exception.
        /// </summary>
        public void KBEdit()
        {
            ConvertToEmptyString();

            if (string.IsNullOrWhiteSpace(this.Name))
            {
                errorMessages += "Name: required\n";
            }

            if (string.IsNullOrWhiteSpace(this.Description))
            {
                errorMessages += "Description: required\n";
            }

            CheckIfSameNameExists();
            CheckIfPriceIsNotLessThanZero();


            if (errorMessages != "")
            {
                throw new Exception(errorMessages);
            }
        }

        /// <summary>
        /// Check if the price input is greater than 0
        /// if not, add error message
        /// </summary>
        private void CheckIfPriceIsNotLessThanZero()
        {
            if (this.Price < 0)
            {
                errorMessages += "Price: cannot be less than 0\n";
            }
        }

        /// <summary>
        /// Check if given name exists in the file 
        /// </summary>
        private void CheckIfSameNameExists()
        {
            try
            {
                using (reader = new StreamReader(stockPath))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        string[] stockRcords = record.Split('\t');
                        if (stockRcords[1] == this.Name)
                        {
                            isNameOnTheRecord = true;
                            if (!record.StartsWith(StockId + "\t"))
                            {
                                errorMessages = "Name: already exists\n" + errorMessages;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while reading files: " + ex.Message);
            }
        }

        /// <summary>
        /// Convert input value to an empty string with both end trimmed 
        /// </summary>
        private void ConvertToEmptyString()
        {
            this.Name = (this.Name + "").Trim();
            this.Description = (this.Description + "").Trim();
        }

        /// <summary>
        /// Create an unique Id for a record to be saved 
        /// </summary>
        private void CreateStockId()
        {
            List<int> stockIds = new List<int>();
            try
            {
                using (reader = new StreamReader(stockPath))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        stockIds.Add(int.Parse(record.Substring(0, record.IndexOf("\t"))));
                    }
                }

                for (int i = 1; i < 1000; i++)
                {
                    if (!stockIds.Contains(i))
                    {
                        this.StockId = i;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while reading files: " + ex.Message);
            }
        }

        /// <summary>
        /// Sort the record in order by name 
        /// compare input name with the name in the record and return an object 
        /// accordingly to use as an index for the cursor in the list box
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static KBStock GetProvinceNameEqualOrGreater(string name)
        {
            List<KBStock> provinces = KBGetStocks();
            provinces = provinces.OrderBy(a => a.Name).ToList();
            foreach (var item in provinces)
            {
                if (item.Name.CompareTo(name) >= 0)
                {
                    return item;
                }
            }
            if (provinces.Count > 0)
            {
                return provinces[provinces.Count - 1];
            }
            else
            {
                return null;
            }
        }
    }
}
