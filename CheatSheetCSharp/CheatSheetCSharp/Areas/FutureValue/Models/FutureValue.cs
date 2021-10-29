using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Areas.FutureValue.Models
{
    public class FutureValue
    {
        public decimal MonthlyInvestment { get; set; }
        public decimal YearlyInterestRate { get; set; }
        public int Years { get; set; }
        public decimal FValue { get; set; }

        public void GetFutureValue()
        {
            int months = Years * 12;
            decimal monthlyInterestRate = YearlyInterestRate / 12 / 100;
            for (int i = 0; i < months; i++)
            {
                FValue = (FValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }
            return FValue;
        }
    }
}
