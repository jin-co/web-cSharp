using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KBFinalExam
{
    class Vaccination
    {
        #region Properties
        public Int32 VaccinationId { get; set; }
        public string PatientName { get; set; }
        public string Contact { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentTime { get; set; }
        public bool FollowupRequired { get; set; }
        public DateTime FollowupDate { get; set; }
        public DateTime FollowupTime { get; set; }
        public string Name { get; private set; }
        #endregion
        #region Constructor
        public Vaccination()
        {
            FollowupRequired = true;
        }
        #endregion

        #region Variables
        static string fileName = "vaccination.txt", archive = "archive.txt";
        static StreamReader reader;
        static StreamWriter writer;
        #endregion

        #region Gets
        public static List<Vaccination> GetVaccinationRecords()
        {
            CheckFile();
            List<Vaccination> vaccinations = new List<Vaccination>();
            try
            {
                using(reader = new StreamReader(fileName))
                {
                    string record;
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        vaccinations.Add(Parse(record));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred during the process\t" + ex.Message);
            }
            return vaccinations;
        }

        public static Vaccination GetVaccinationById(int truckId)
        {
            CheckFile();
            Vaccination vaccination = null;
            try
            {
                using(reader = new StreamReader(fileName))
                {
                    string record;
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        if (record.StartsWith(truckId + "\t"))
                        {
                            vaccination = Parse(record);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred during the process\t" + ex.Message);
            }
            return vaccination;
        }

        // record id
        public static int GetUniqueVaccinationId()
        {
            CheckFile();
            List<int> vaccinationId = new List<int>();
            int id = 0;
            try
            {
                string record;
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        vaccinationId.Add(int.Parse(record.Substring(0, record.IndexOf("\t"))));
                    }
                }

                for (int i = 1; i < 1000; i++)
                {
                    if (!vaccinationId.Contains(i))
                    {
                        id = i;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while reading files: " + ex.Message);
            }
            return id;
        }
        #endregion

        #region Methods
        // Save
        public void Save()
        {
            Edit();
            Vaccination vaccintionId = GetVaccinationById(VaccinationId);
            if (vaccintionId == null)
            {
                Add();
            }
            else
            {
                Update();
            }
        }

        // Update
        private void Update()
        {
            CreateBackupFile();
            try
            {
                using(reader = new StreamReader(archive))
                {
                    using(writer = new StreamWriter(fileName, append: false))
                    {
                        string record;
                        while (!reader.EndOfStream)
                        {
                            record = reader.ReadLine();
                            if (record.StartsWith(this.VaccinationId + "\t"))
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
                File.Delete(fileName);
                File.Copy(archive, fileName);
                throw new Exception("Errors while updating a record\t: " + ex.Message);
            }
        }

        // Add
        private void Add()
        {
            try
            {
                using(writer = new StreamWriter(fileName, append:true))
                {
                    writer.WriteLine(ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errors while adding a new record\t: " + ex.Message);
            }
        }
        #endregion

        #region Utilities Methods
        // Edit
        private void Edit()
        {
            CheckFile();
            TrimString();
            string errors = "";
            // id
            if (this.VaccinationId <= 0)
            {
                errors += "Id: Must be greater than 0\n";
            }

            // name
            if (PatientName == "")
            {
                errors += "Name: Cannot be empty\n";
            }
            if (!this.PatientName.Contains(" "))
            {
                errors += "Name: Must be 2 words or more\n";
            }
            else
            {
                string[] names = this.PatientName.Split(' ');
                char[] words = this.PatientName.ToCharArray();
                foreach (var word in words)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i].Length < 2)
                        {
                            errors += "Name: Each word must contain 2 words or more letters\n";
                        }
                    }
                }
            }

            // contact
            Regex patternPhone = new Regex(@"^\d{3}-\d{3}-\d{4}$");
            Regex patternEmail = new Regex(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$");

            if (this.Contact == "")
            {
                errors += "Contact: Cannot be empty\n";
            }
            if (!patternPhone.IsMatch(this.Contact) && !patternEmail.IsMatch(this.Contact))
            {
                errors += "Contact: Must be phone (000-000-0000) or email\n";
            }

            if (AppointmentDate < DateTime.Now)
            {
                errors += "Appoint date: Must be in the future\n";
            }
            if (AppointmentTime.Hour < 8 || AppointmentTime.Hour > 21)
            {
                errors += "Appointment time: Must be between 08:00AM and 09:00 PM\n";
            }
            FollowupDate = AppointmentDate.AddDays(28);
            FollowupTime = this.AppointmentTime;

            if (errors != "")
            {
                throw new Exception(errors);
            }
        }

        // To string
        public override string ToString()
        {
            return $"{VaccinationId}\t" +
                $"{PatientName}\t" +
                $"{Contact}" +
                $"{AppointmentDate.ToString("yyyy-MM-dd")}" +
                $"{AppointmentTime.ToString("h:mm tt")}" +
                $"{FollowupRequired}" +
                $"{FollowupDate.ToString("yyyy-MM-dd")}" +
                $"{FollowupTime.ToString("h:mm tt")}";
        }
        
        // Parse
        public static Vaccination Parse(string input)
        {
            Vaccination vaccinations = new Vaccination();
            string[] record = input.Split('\t');
            vaccinations.VaccinationId = Convert.ToInt32(record[0]);
            vaccinations.PatientName = record[1];
            vaccinations.Contact = record[2];
            vaccinations.AppointmentDate = Convert.ToDateTime(record[3]);
            vaccinations.AppointmentTime = Convert.ToDateTime(record[4]);
            vaccinations.FollowupRequired = Convert.ToBoolean(record[5]);
            vaccinations.FollowupDate = Convert.ToDateTime(record[6]);
            vaccinations.FollowupTime = Convert.ToDateTime(record[7]);
            return vaccinations;
        }

        // File Check
        public static void CheckFile()
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Dispose();
            }
        }

        // File backup for update and delete
        private void CreateBackupFile()
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
                throw;
            }
        }
        #endregion

        // Convert null to empty string and trim
        private void TrimString()
        {
            this.PatientName = (this.PatientName + " ").Trim();
            this.Contact = (this.Contact + " ").Trim();
        }
    }
}
