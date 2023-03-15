using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            //WriteLine("Demo 2: string array");
            //string[] namesArray = { "John", "Amy", "William" };
            //namesArray[0] = "Will";
            //namesArray = new string[] { "Will", "Amy", "Adam"};
            //namesArray = new string[5];
            //WriteLine("Length of namesArray is " + namesArray.Length);
            //WriteLine("Displaying string array elements...");

            //for (int i = 0; i < namesArray.Length; i++)
            //{
            //    WriteLine(namesArray[i]);
            //    Write("Enter Name " + (i+1) + ": ");
            //    namesArray[i] = ReadLine();
            //}

            //DisplayArray(namesArray);

            WriteLine("Demo 3: working with double[], user input, validations");
            int numGrades;
            Write("How many grades do you have? ");
            while(!int.TryParse(ReadLine(), out numGrades) 
                                || numGrades <= 0)
            {
                Write("Number of grades must be whole number > 0. Please re-enter: ");
            }
            WriteLine("Number of grades that need to be entered is " + numGrades);
            double[] grades = new double[numGrades];
            LoadGrades(grades);
            WriteLine(grades[0]);
            WriteLine(grades); //simply displays data type, cannot WriteLine array directly
            DisplayArray(grades);
            double avg = GetAvg(grades);
            WriteLine("Average is {0:F2}", avg);
            WriteLine("Average is " + GetAvg(grades).ToString("F2"));

            //Practice Exercise 2: After completing the max computation given below
            //in practice exercise 1, call this method and assign returned value to
            //a double array

            double[] MinAndMax = GetMinMax(grades);
            WriteLine("Minimum = {0:F2}, Maximum = {1:F2}", MinAndMax[0], MinAndMax[1]);

            //Additional Practice: For each of these below,
            //ask the user how many objects you need to process, 
            //and set up a loop to assign objects to the array of objects
            //Additional practice 1: using array of objects e.g., DogFood[] from your assignment main program, 
            //find the total of All Objects BrandTotal, and then compute discount etc.

            //Additional practice 2: using array of Ticket objects Ticket[] in your program
            //Additional practice 3: using array of objects for RealEstate[] in the real estate application

            //Note in this case, suppose you have the user entering number of tickets
            //as numTickets
            //Ticket[] AllTickets = new Ticket[numTickets];
            //Then each element i in AllTickets corresponds to one object.
            //AllTickets[0] is the first ticket object
            //AllTickets[0].StudentName, AllTickets[0].StudentCategory, AllTickets[0].ToString(),
            //AllTickets[0].Fine are all possible to get these values...



        }
        static double[] GetMinMax(double[] anyGrades)
        {
            double[] MinMax = new double[2]; //2-element double array that stores
                                             //min in index 0 and max in index 1
                                             //MinMax[0] - minimum of anyGrades
                                             //MinMax[1] - maximum of anyGrades

            //find minimum and maximum and put it in MinMax[0] and MinMax[1]

            double min = anyGrades[0]; //start with min being the first (index 0) element
            //compare element at index 1 to last index to see if 
            //each element is less than current minimum
            for (int i = 1; i < anyGrades.Length; i++)
            {
                if (anyGrades[i] < min)
                {
                    min = anyGrades[i]; //if current element is less than min, then update min to current element
                }
            }
            MinMax[0] = min; //assign first element in MinMax to min that you computed
            //Practice Exercise 1: Compute the maximum using
            //another variable max, and using similar logic
            //to compute the maximum of anyGrades
            //assign the max you computed to MinMax[1]

            double max = anyGrades[0];
            for (int i = 1; i < anyGrades.Length; i++)
            {
                if (anyGrades[i] > max)
                {
                    max = anyGrades[i];
                }
            }
            MinMax[1] = max;
            return MinMax;

        }
        static double GetAvg(double[] anyGrades)
        {
            double avg = 0;
            double sum = 0;
            foreach(double grade in anyGrades)
            {
                sum += grade;
            }
            avg = sum / anyGrades.Length;
            return avg;
        }
        static void LoadGrades(double[] anyGrades)
        {
            WriteLine("Let us enter the grades...");
            for (int i = 0; i < anyGrades.Length; i++)
            {
                double grade;
                Write("Please enter the grade for student " + (i + 1) + ": ");
                while(!double.TryParse(ReadLine(), out grade)
                            || grade < 0 || grade > 100)
                {
                    Write("Re-enter grade for student " + (i + 1) + ": ");
                }
                anyGrades[i] = grade; //assigns grade value to the ith element in the array
            }
        }
        static void DisplayArray(double[] anyGrades)
        {
            //grade - iterator variable
            //foreach - readonly loop
            foreach(double grade in anyGrades)
            {
                WriteLine(grade.ToString("F2"));
                //grade = 76; //foreach - readonly, cannot modify the iterator variable
            }
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
