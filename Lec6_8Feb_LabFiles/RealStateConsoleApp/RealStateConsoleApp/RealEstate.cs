using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RealStateConsoleApp
{
    internal class RealEstate
    {
        public string Address { 
            get; 
        }
        public int YearBuilt {
            get;
        }
        public double PurchasePrice {
            get;
        }
        public double IncomeFromRent {
            get;
            set;
        }
        public double MonthlyExpense {
            get;
            set;
        }
        private double Test;
        public double GetTest() { 
            return Test;
        }
        public void SetMonthlyExpenses(double test) {   
            this.Test = test;
        }

        public RealEstate(string address, int yearBuilt, double purchasePrice) {
            this.Address = address;
            this.YearBuilt =  yearBuilt;
            this.PurchasePrice = purchasePrice;
        }
        public override string ToString() {
            string outputStr = "Year: " + YearBuilt + "\n" +
                               "Address: " + Address + "\n" +
                               "Purchase Price: " + PurchasePrice.ToString("C") + "\n" +
                               "IncomeFromRent" + IncomeFromRent.ToString("C") +"\n" +
                               "MontlyExpenses" + MonthlyExpense.ToString("C") + "\n";
            return outputStr;
        }

    }
}
