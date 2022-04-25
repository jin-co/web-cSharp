using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass_3_KwangjinBaek_
{
    // employee class that stores employee's information
    // and calculate the year of service of an employee
    class Employee
    {
        #region properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public double AnnualSalary { get; set; }
        #endregion

        // calculate the year a worker has worked
        public int GetYearsOfService()
        {
            int result = 0;
            DateTime today = DateTime.Today;
            TimeSpan timespan = today.Subtract(StartDate);
            result = (timespan.Days / 365);
            return result;
        }
    }
}
