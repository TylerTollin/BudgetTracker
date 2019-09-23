using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BudgetTrackerMain
{
    public class IncomeCalculations
    {
        public double YearlyGrossIncome()
        {
            double incomeGrossYear = 90000.00;
            return Math.Round(incomeGrossYear, 2);
        }

        public double MonthlyGrossIncome()
        {
            double incomeGrossMonth = YearlyGrossIncome() / 12;
            return Math.Round(incomeGrossMonth, 2);
        }

        public double WeeklyGrossIncome()
        {
            double weeklyGrossIncome = YearlyGrossIncome() / 52;
            return Math.Round(weeklyGrossIncome, 2);
        }
    }
}
