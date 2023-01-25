using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InputCarpetProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lengthInFt = GetDimension("length");
            double widthInFt = GetDimension("width");
            WriteLine("Total length = {0:F2}, Total Width ={1:F2}", lengthInFt, widthInFt);
            double areaInSqYds = GetAreaInSqYds(lengthInFt, widthInFt);
            WriteLine("Area in sq. yds ={0:F2}", areaInSqYds);
            bool testing = GetCarpetPrices("berber", "pile", out double berberPrice, out double pilePrice);
            WriteLine("Does the method worked {0}?",testing);
            WriteLine("Berber price = {0:C} per sq.yd, Pile price = {1:C} per sq.yd",berberPrice,pilePrice);
            double berberCost = GetCarpetCost(berberPrice, areaInSqYds);
            double pileCost = GetCarpetCost(pilePrice, areaInSqYds);
            WriteLine("Berber cost = {0:C}, Pile cost = {1:C}", berberCost, pileCost);
        }

        // Write a value returning method, GetCarpetCost() that returns the double
        static double GetDimension(string dimension) {
            try
            {
                double totalDimension;
                Write("Enter the {0} dimension in feet:", dimension);
                int feet = int.Parse(ReadLine());
                Write("Enter the {0} dimension in inches:", dimension);
                int inches = int.Parse(ReadLine());
                totalDimension = feet + (double)inches / 12;
                return totalDimension;
            }
            catch {
                Clear();
                WriteLine("{0} must be entered as an integer. Please try again",dimension);
                return GetDimension(dimension);
            }
                
         }
        static double GetAreaInSqYds(double width, double lenght) {
            const int SQFT_PER_SQYD = 9;
            double sqYds = width* lenght/SQFT_PER_SQYD;
            return sqYds;
        }
        static bool GetCarpetPrices(string carpetType1, string carpetType2, out double price1, out double price2) {
            Write("Enter the price for {0}:",carpetType1);
            price1 = double.Parse(ReadLine());
            Write("Enter the price for {0}:", carpetType2);
            price2 = double.Parse(ReadLine());
            bool test = true;
            return test;
        }
        static double GetCarpetCost(double carpetPrice, double areaInSqYds) { 
            return carpetPrice*areaInSqYds; 
        }
    }
}
