using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RealStateProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal price = 542392.42M;
            RealState premier = new RealState(2023,price,"408 E Columbia");
            //decimal insurancePay = InputYearlyPay("Insurance");
            //decimal yearlyExpensesPay = InputYearlyPay("Expenses");
            premier.CalcMonthEarning (2500,MonthlyExpense("Light Bill")+ InputYearlyPay("Insurance")+ InputYearlyPay("Expenses"));
            WriteLine(premier);


        }
        public static decimal InputYearlyPay(string payType)
        {
            WriteLine("Please input Yearly {0} payment", payType);
            decimal amt = decimal.Parse(ReadLine())/12;
            return amt;
        }
        public static decimal MonthlyExpense (string expenseName) {
            WriteLine(" Please enter Monthly {0} cost", expenseName);
            decimal amt = decimal.Parse(ReadLine());
            return amt;
        }
    }
 
}
