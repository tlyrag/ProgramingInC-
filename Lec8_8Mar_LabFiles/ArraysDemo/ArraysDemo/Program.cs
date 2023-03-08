using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteLine("Demo 1: Initializing and displaying an integer array");
            int[] numbersArray = new int[] { 78, 89, 77, 23, 98 };
            int numberOfElements = numbersArray.Length;
            for (int i = 0; i < numberOfElements; i++)
            {
                Write(numbersArray[i] + "\t");
            }
            WriteLine();

            WriteLine("Demo 2: string array");
            string[] namesArray = { "John", "Amy", "William" };
            WriteLine("Displaying string array elements...");

            for (int i = 0; i < namesArray.Length; i++)
            {
                WriteLine(namesArray[i]);
            }

            DisplayArray(namesArray);
        }

        static void DisplayArray(string[] anyArray)
        {
            WriteLine("Inside Display Array method using array as parameter....");
            for (int i = 0; i < anyArray.Length; i++)
            {
                WriteLine(anyArray[i]);
            }
            WriteLine();
        }



    }
}
