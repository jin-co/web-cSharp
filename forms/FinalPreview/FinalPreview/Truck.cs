using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPreview
{
    class Truck
    {
        #region properties
        public int TruckId { get; set; }
        public DateTime DateMeasured { get; set; }
        public int TareWeight { get; set; }
        public int GrossWeight { get; set; }
        public int NetWeight { get; set; }

        #endregion
        #region constructors
        public Truck()
        {
            TareWeight = 0;
            GrossWeight = 0;
            NetWeight = -1;
        }
        #endregion

        #region variables
        static string fileName = "truck.txt", archive = "archive.txt";
        static StreamReader reader;
        static StreamWriter writer;
        #endregion
        
        #region get methods
        public static List<Truck> GetTruck()
        {
            CheckFile();
            List<Truck> trucks = new List<Truck>();
            using(reader = new StreamReader(fileName))
            {
                string record;
                while (!reader.EndOfStream)
                {
                    record = reader.ReadLine();
                    trucks.Add(Parse(record));
                }
            }
            return trucks;
        }

        public static Truck GetTruckById(int truckId)
        {
            CheckFile();
            Truck truck = null;
            using (reader = new StreamReader(fileName))
            {
                string record;
                while (!reader.EndOfStream)
                {
                    record = reader.ReadLine();
                    if (record.StartsWith(truckId + "\t"))
                    {
                        truck = Parse(record);
                        break;
                    }
                }
            }
            return truck;
        }
        #endregion
        
        #region save, add, update and delete methods
        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            Edit();
            Truck existingTruck = GetTruckById(TruckId);
            if (existingTruck == null)
            {
                Add();
            }
            else if(existingTruck.NetWeight != -1)
            {
                Update();
            }
            else
            {
                if (this.TareWeight > existingTruck.TareWeight)
                {
                    this.GrossWeight = this.TareWeight;
                    this.TareWeight = existingTruck.TareWeight;
                }
                else
                {
                    this.GrossWeight = existingTruck.GrossWeight;
                }
                this.NetWeight = this.GrossWeight - this.TareWeight;
                Update();
            }
        }

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
                throw new Exception("exception trying to add new record:\t" + ex.Message);
            }
        }

        private void Update()
        {
            string record;
            try
            {
                if (File.Exists(archive))
                {
                    File.Delete(archive);
                    File.Move(fileName, archive);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("exception trying to archive file before update:\t" + ex.Message);
            }
            
            try
            {
                using(reader = new StreamReader(archive))
                {
                    using (writer = new StreamWriter(fileName, append: false))
                    {
                        while (!reader.EndOfStream)
                        {
                            record = reader.ReadLine();
                            if (record.StartsWith(TruckId + "\t"))
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
                File.Delete(archive);
                
            }
            catch (Exception ex)
            {
                if (File.Exists(archive))
                {
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                        File.Move(archive, fileName);
                    }
                }
                throw new Exception("exception trying to updated record:\t" + ex.Message);
            }
        }
        #endregion


        #region utility methods: to string, parse, edit, check file
        private void Edit()
        {
            CheckFile();
            string errors = "";
            if (TruckId <= 0)
            {
                errors += "truck ID must be greater than zero\n";
            }
            if (DateMeasured.Date > DateTime.Today)
            {
                errors += "date measured cannot be in the future\n";
            }
            if (TareWeight <= 0)
            {
                errors += "weight must be greater than 0\n";
            }
            
            GrossWeight = 0;
            NetWeight = -1;

            if (errors != "")
            {
                throw new Exception(errors);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{TruckId}\t{DateMeasured}\t" +
                $"{TareWeight}\t{GrossWeight}\t" +
                $"{NetWeight}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public static Truck Parse(string record)
        {
            Truck truck = new Truck();
            string[] fields = record.Split('\t');
            truck.TruckId = Convert.ToInt32(fields[0]);
            truck.DateMeasured = Convert.ToDateTime(fields[1]);
            truck.TareWeight = Convert.ToInt32(fields[2]);
            truck.GrossWeight = Convert.ToInt32(fields[3]);
            truck.NetWeight = Convert.ToInt32(fields[4]);
            return truck;
        }

        /// <summary>
        /// 
        /// </summary>
        private static void CheckFile()
        {
            if (!File.Exists(fileName))
            {
                if (File.Exists(archive))
                {
                    File.Move(archive, fileName);
                }
                else
                {
                    File.Create(fileName).Dispose();
                }
            }
        }
        #endregion
    }
}
