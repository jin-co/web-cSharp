using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Areas.FutureValue.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Monthly required")]
        public decimal MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Year interest required")]
        public decimal YearlyInterestRate { get; set; }

        [Required(ErrorMessage = "Years required")]
        public int Years { get; set; }

        public decimal GetFutureValue()
        {
            int months = Years * 12;
            decimal monthlyInterestRate = YearlyInterestRate / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) *
                                (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    }
}
