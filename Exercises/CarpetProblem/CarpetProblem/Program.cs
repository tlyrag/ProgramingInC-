using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Console;

namespace CarpetProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convert Length and Inches to same unit
            double lengthInfeet = 12;
            double lengthInInches = 2;
            double widthInFeet = 14;
            double widthInInches = 7;
            
            double totalLenght = FeetInchesConverter(lengthInfeet, lengthInInches);
            double totalWidth = FeetInchesConverter(widthInFeet, widthInInches);
            WriteLine("Total Length is:{0} and total Width is {1}",totalLenght, totalWidth);

            //Calculate the area of the room
            double totalAreaInFeet =RoomAreaCalculator(totalWidth, totalLenght);
            
            //Convert the area to Yard
            double totalAreaInYd = SqFeetYardConverter(totalAreaInFeet);
            WriteLine("Total Area in feet is:{0} and total Area in Yards is {1}",totalAreaInFeet,totalAreaInYd);
           
            //Calculate the price
            double berberYdPrice = 27.95;
            double pileYdPrice = 15.95;
            double beberPrice = PriceCalculator(berberYdPrice, totalAreaInYd);
            double pilePirce = PriceCalculator(pileYdPrice, totalAreaInYd);
            
            //Display the selection cost
            displayResult("Berber", beberPrice);
            displayResult("Pile", pilePirce);
        }
        static double FeetInchesConverter(double feet, double inches)
        {
            double totalMeasureinFeet = feet + inches/12;
            return totalMeasureinFeet;

        }
        static double RoomAreaCalculator(double width,double length)
        {
            double totalAreainInch = width * length; 
            return totalAreainInch;
        }
        static double SqFeetYardConverter(double sqFeet)
        {
            double sqYard = sqFeet/9;
            return sqYard;
        }
        static double PriceCalculator(double area, double pricePerArea)
        {
            double finalPrice =  area * pricePerArea;
            return finalPrice;
        }
        static void displayResult(string carpetName,double price) {
            WriteLine("------------------------");
            WriteLine("Calculating the price of {0}: ",carpetName);
            WriteLine("");
            WriteLine("The total cost of {0} will be {1:c}",carpetName,price);
            WriteLine("------------------------");
        }
    }
}
