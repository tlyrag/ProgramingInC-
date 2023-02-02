using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RealStateProblem
{
    internal class RealState
    {
        public int builtYear { get; set; }
        public decimal purchasePrice { get; set; }
        public string address { get; set; }
        public decimal monthlyIncome { get; set; }
        public decimal expenses { get; set; }
        public decimal cashFlow { get; set; }


        public RealState(int builtYear, decimal purchasePrice,string address ) { 
            this.builtYear = builtYear;
            this.purchasePrice = purchasePrice;
            this.address = address;
        }

        public void CalcMonthEarning(decimal monthlyIncome, decimal expenses) {
            this.cashFlow = monthlyIncome - expenses; 
        }


        public override string ToString()
        {
            string unitInfo = $"The Unit located at {this.address} was built in {this.builtYear}, and purchased by {this.purchasePrice.ToString("f2")}\n" +
                $"and its currently generating an Yearly revenue of {this.cashFlow.ToString("C2")}";
            return unitInfo;
        }
    }
}
