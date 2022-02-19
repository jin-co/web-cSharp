using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermKB
{
    public static class DateSolver
    {
        public static string Analyze(int month, int day, int year)
        {
            return month.ToString() + ". " +
                day.ToString() + ". " +
                year.ToString() + ". ";
        }
    }
}
