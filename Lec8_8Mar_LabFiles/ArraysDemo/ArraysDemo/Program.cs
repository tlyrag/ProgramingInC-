using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //WriteLine("Demo 1: Initializing and displaying an integer array");
            //int[] numbersArray = new int[] { 78, 89, 77, 23, 98 };
            //int numberOfElements = numbersArray.Length;
            //for (int i = 0; i < numberOfElements; i++)
            //{
            //    Write(numbersArray[i] + "\t");
            //}
            
            //WriteLine();
            //foreach(int a in numbersArray)
            //{
            //    Write(a + "\t");
            //}

            //WriteLine("Demo 2: string array");
            //string[] namesArray = { "John", "Amy", "William" };
            
            //WriteLine("Displaying string array elements...");

            //for (int i = 0; i < namesArray.Length; i++)
            //{
            //    //WriteLine(namesArray[i]);
            //    Write("Enter Name " + i + 1 + " :");
            //    namesArray[i] = ReadLine();
            //}

            //DisplayArray(namesArray);

            WriteLine("Demo 3: working with double[], user input, validations");
            int numGrades;
            Write("How many grades do you have: ");
            while(!int.TryParse(ReadLine(),out numGrades) || numGrades <=0)
            {
                Write("Number of grades mus be whole number >0, Please re-enter: ");
            }
            double[] gradeArray = new double[numGrades];
            
            LoadGrades(gradeArray);
           // Write(gradeArray); // simply display data type, cannot display the array directly
            DisplayArray(gradeArray);
            double gradeAvg= GetAverage(gradeArray);

            WriteLine($"Average is: {gradeAvg:f2}");

        }

        static void DisplayArray( string[] anyArray)
        {
            WriteLine("Inside Display Array method using array as parameter....");
            for (int i = 0; i < anyArray.Length; i++)
            {
                WriteLine(anyArray[i]);
            }
            WriteLine();
        }

        static void DisplayArray(double[] anyArray)
        {
            WriteLine("Inside Display Array method using array as parameter....");
            foreach(double arg in anyArray)
            {
                WriteLine(arg);
            }
            WriteLine();
        }

        static void LoadGrades(double[] anyGrades)
        {
            WriteLine("Let us enter the grade");
            for (int i = 0; i < anyGrades.Length; i++)
            {
                double grade;
                Write($"Please enter the grade for student {i+1}: ");
                while (!double.TryParse(ReadLine(), out grade) || grade<0 || grade>100)
                {
                    Write($"Please re-enter the grade for student {i + 1}: ");
                }
                anyGrades[i] = grade;
                  

                
            }
        }
        static double GetAverage(double[] anyGrades) {
            double avg = 0;
            double sum = 0;

            foreach(double grades in anyGrades)
            {
                sum += grades;
            }
            avg= sum / anyGrades.Length;
            return avg;
        }
        static double[] getMinMax(double[] anyGrades)
        {
            double[] minMax = new double[2];
                double min = anyGrades[0];
            foreach(double grades in anyGrades)
            {
                
            }
            return minMax;
            
        }




}
}
