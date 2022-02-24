using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermKB
{
    public static class DateSolver
    {
        private const int DATE_MIN = 1;
        private const int MONTH_MAX = 12;
        private const int DAY_MAX = 31;
        private const int YEAR_MAX = 2022;

        public static string Analyze(int month, int day, int year)
        {
            string result = "System date is updated ";
            string monthResult = month.ToString();
            string dayResult = day.ToString();
            string yearResult = year.ToString();
            if (month > MONTH_MAX || month < DATE_MIN)
            {
                monthResult = "\nMonth: value out of range";
                result = "";
            }
            
            if (day > DAY_MAX || month < DATE_MIN)
            {
                dayResult = "\nDay: value out of range";
                result = "";
            }

            if (year > YEAR_MAX || month < DATE_MIN)
            {
                yearResult = "\nYear: value out of range";
                result = "";
            }

            return result + 
                monthResult + ". " +
                dayResult + ". " +
                yearResult + ". ";
        }
    }
}
