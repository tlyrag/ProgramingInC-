using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RealStateConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
            RealEstate myBuilding1 = new RealEstate("555 E Columbia", 1999, 500452.65);
            WriteLine(myBuilding1);
            myBuilding1.IncomeFromRent = 1299.99;
            myBuilding1.MonthlyExpense = 767.6;
            WriteLine(myBuilding1);
            GetAddressYearAndPrice(out string address, out int year, out double price);
            RealEstate myBuilding2 = new RealEstate(address, year, price);
            WriteLine(myBuilding2);
            LoadIncomeAndExpense(myBuilding2);
            WriteLine(myBuilding2);
            */
            object MyBuilding3 = CreateBuilding();
            WriteLine(MyBuilding3);


        }
        static void GetAddressYearAndPrice(out string address,out int year,out double price)
        {
                WriteLine("Please enter Address:");
                address = ReadLine();
                WriteLine("Please enter Year:");
                year = int.Parse(ReadLine());
                WriteLine("Please enter Price:");
                price = double.Parse(ReadLine());
         }
        static void LoadIncomeAndExpense(RealEstate bld) {
            WriteLine("Please enter {0} rent income",bld.Address);
            bld.IncomeFromRent = double.Parse(ReadLine());
            WriteLine("Please enter enter {0} the expense",bld.Address);
            bld.MonthlyExpense = double.Parse(ReadLine());
        }
        static object CreateBuilding ()
        {  /*
            WriteLine("Please enter Address:");
            string address = ReadLine();
            WriteLine("Please enter Year:");
            int year = int.Parse(ReadLine());
            WriteLine("Please enter Price:");
            double price = double.Parse(ReadLine());
          
            WriteLine("Please enter {0} rent income", bld.Address);
            bld.IncomeFromRent = double.Parse(ReadLine());
            WriteLine("Please enter enter {0} the expense", bld.Address);
            bld.MonthlyExpense = double.Parse(ReadLine());
            */
            GetAddressYearAndPrice(out string address, out int year, out double price);
            RealEstate bld = new RealEstate(address, year, price);
            LoadIncomeAndExpense(bld);
            return bld;
            
        }
    }
}
