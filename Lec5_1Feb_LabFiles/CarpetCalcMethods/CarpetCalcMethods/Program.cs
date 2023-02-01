using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarpetCalcMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lengthInFt = GetDimension("length");
            double widthInFt = GetDimension("width");
            WriteLine("Total length = {0:F2}, Total width = {1:F2}",
                                                lengthInFt,widthInFt);
            double areaInSqYds = GetAreaInSqYds(lengthInFt, widthInFt);
            WriteLine("Area in sq. yds = {0:F2}", areaInSqYds);
            GetCarpetPrices("berber","pile",
                  out double berberPrice, out double pilePrice);
            WriteLine("Berber price = {0:C} per sq. yd, " +
                "Pile price = {1:C} per sq. yd", 
                                berberPrice, pilePrice);
            double berberCost = GetCarpetCost(berberPrice, areaInSqYds);
            double pileCost = GetCarpetCost(pilePrice, areaInSqYds);
            WriteLine("Berber cost = {0:C}, " +
                "Pile cost = {1:C}",
                                berberCost, pileCost);
            //Practice Exercise: After completing 
            //DisplayBanner() method definition below.
            //Call it with needed input arguments
            DisplayBanner(lengthInFt, widthInFt,
                berberPrice, pilePrice, berberCost, pileCost);

        }

        //method definition - outside all other methods, inside program class

        //Display banner method definition
        //Practice Exercise: See the method definition below
        //DisplayBanner is similar to DisplayBanner in the Lec4MethodsDemo
        //It is a void method that takes as input lengthFt, widthFt,
        //berberPrice, pilePrice,berberCost, pileCost, 
        //displays formatted output in banner form
        static void DisplayBanner(double lengthFt, double widthFt,
                                    double berberPrice, double pilePrice,
                                       double berberCost, double pileCost)
        {
            WriteLine(new string('*', 50));
            WriteLine("*{0, 16}: {1, -8:F1}{2, -22}*", "Length", lengthFt, "Feet");
            //Practice exercise - complete this banner - similar to Lec4Methods demo Display banner
            //and using the format given above, complete the banner to display
            //widthFt, berberPrice, pilePrice, berberCost, pileCost
            WriteLine("*{0, 16}: {1, -8:F1}{2, -22}*", "Width", widthFt, "Feet");
            WriteLine("*{0, 16}: {1, -8:C}{2, -22}*", "Berber Price", berberPrice, "Per Sq. Yd."); //currency specifier is given by C in format pattern
            WriteLine("*{0, 16}: {1, -8:C}{2, -22}*", "Pile Price", pilePrice, "Per Sq. Yd.");
            WriteLine("*{0, 16}: {1, -30:C}*", "Berber Cost", berberCost);
            WriteLine("*{0, 16}: {1, -30:C}*", "Pile Cost", pileCost);
            WriteLine(new string('*', 50));
            //Don't forget to call this method in the main method to see the result
        }


        //write a value returning method,
        //GetCarpetCost() that returns the double cost given 
        //carpetPrice and areaInSqYds
        static double GetCarpetCost(double carpetPrice, double areaInSqYds)
        {
            return carpetPrice * areaInSqYds;
        }
        static void GetCarpetPrices(string carpetType1, 
                                    string carpetType2,
                                    out double price1, 
                                    out double price2)
        {
            Write("Enter the price for " + carpetType1 + ": ");
            price1 = double.Parse(ReadLine());
            Write("Enter the price for " + carpetType2 + ": ");
            price2 = double.Parse(ReadLine());
        }
        static double GetAreaInSqYds(double length, double width)
        {
            const int SQFT_PER_SQYD = 9;
            //SQFT_PER_SQYD = 20; //constants cannot be changed
            double sqYds = (length * width) / SQFT_PER_SQYD;
            return sqYds;
        }
        static double GetDimension(string dimension)
        {
            //double totalDimension;
            Write("Enter the " + dimension + " in feet: ");
            int feet = int.Parse(ReadLine());
            Write("Enter the " + dimension + " in inches: ");
            int inches = int.Parse(ReadLine());
            double totalDimension = feet + (double)inches/12;
            return totalDimension;
        }
    }
}
