using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackerMain
{
    public class TaxCalculations
    {
        double taxFederalRate = 0.1008;
        double taxStateRate = 0.0396;
        double taxSocSecRate = 0.0620;
        double taxMedicareRate = 0.0145;
        IncomeCalculations GrossIncome = new IncomeCalculations();

        //public double CalculateTaxableIncome()
        //{
        //    double incomeTaxableYearly = ;
        //}

        public double YearlyFederalIncome()
        {
            double taxFederalYear = GrossIncome.YearlyGrossIncome() * taxFederalRate;
            return Math.Round(taxFederalYear, 2);
        }

        public double MonthlyFederalIncome()
        {
            double taxFederalMonth = YearlyFederalIncome() / 12;
            return Math.Round(taxFederalMonth, 2);
        }

        public double WeeklyFederalIncome()
        {
            double taxFederalWeek = YearlyFederalIncome() / 52;
            return Math.Round(taxFederalWeek, 2);
        }

        public double YearlyStateIncome()
        {
            double taxStateYear = GrossIncome.YearlyGrossIncome() * taxStateRate;
            return Math.Round(taxStateYear, 2);
        }

        public double MonthlyStateIncome()
        {
            double taxStateMonth = YearlyStateIncome() / 12;
            return Math.Round(taxStateMonth, 2);
        }

        public double WeeklyStateIncome()
        {
            double taxStateWeek = YearlyStateIncome() / 52;
            return Math.Round(taxStateWeek, 2);
        }

        public double YearlySocSec()
        {
            double taxSocSecYear = GrossIncome.YearlyGrossIncome() * taxSocSecRate;
            return Math.Round(taxSocSecYear, 2);
        }

        public double MonthlySocSec()
        {
            double taxSocSecMonth = YearlySocSec() / 12;
            return Math.Round(taxSocSecMonth, 2);
        }

        public double WeeklySocSec()
        {
            double taxSocSecWeek = YearlySocSec() / 52;
            return Math.Round(taxSocSecWeek, 2);
        }

        public double YearlyMedicare()
        {
            double taxMedicareYear = GrossIncome.YearlyGrossIncome() * taxMedicareRate;
            return Math.Round(taxMedicareYear, 2);
        }

        public double MonthlyMedicare()
        {
            double taxMedicareMonth = YearlyMedicare() / 12;
            return Math.Round(taxMedicareMonth, 2);
        }

        public double WeeklyMedicare()
        {
            double taxMedicareWeek = YearlyMedicare() / 52;
            return Math.Round(taxMedicareWeek, 2);
        }

        public double YearlyTotalTax()
        {
            double taxTotalYear = YearlyFederalIncome() +
                            YearlyStateIncome() +
                            YearlySocSec() +
                            YearlyMedicare();
            return Math.Round(taxTotalYear, 2);
        }

        public double MonthlyTotalTax()
        {
            double taxTotalMonth = YearlyTotalTax() / 12;
            return Math.Round(taxTotalMonth, 2);
        }

        public double WeeklyTotalTax()
        {
            double taxTotalWeek = YearlyTotalTax() / 52;
            return Math.Round(taxTotalWeek, 2);
        }

        public double YearlyPostTaxIncome()
        {
            double incomePostTaxYear = GrossIncome.YearlyGrossIncome() - YearlyTotalTax();
            return Math.Round(incomePostTaxYear, 2);
        }

        public double MonthlyPostTaxIncome()
        {
            double incomePostTaxMonth = GrossIncome.MonthlyGrossIncome() - MonthlyTotalTax();
            return Math.Round(incomePostTaxMonth, 2);
        }

        public double WeeklyPostTaxIncome()
        {
            double incomePostTaxWeek = GrossIncome.WeeklyGrossIncome() - WeeklyTotalTax();
            return Math.Round(incomePostTaxWeek, 2);
        }
    }
}
