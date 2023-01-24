using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lec3MethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteLine("Lecture 3, Method demo 1: void return type, no input method");
            SayHello();
            SayHello();
            SayHello();
            //WriteLine(helloMsg); //will not work because helloMsg declared inside the method

            WriteLine("Lecture 3, Method demo 2: void return type, two string inputs");
            SayHelloWithInputs("Hello", "Amanda"); // Input arguments
            string anyMsg = "Welcome";
            string name = "Edward";
            SayHelloWithInputs(anyMsg, name);
            WriteLine(name);

            WriteLine("Lecture 3, Method demo 3: Value-returning, no input method");
            string customerName = GetNameFromUser();
            SayHelloWithInputs("Have a good day", customerName);

            SayHelloWithInputs("Hi ", customerName + "! Welcome to the high grade calculator");
            GetTwoGrades(customerName, out double gradeOne, out double gradeTwo);

            double maxGrade = GetMax(gradeOne, gradeTwo);

            DisplayBanner(customerName, gradeOne, gradeTwo, maxGrade);

        }

        static void SayHello()
        {
            string helloMsg = "Hi, Priya!"; //variable is local to this method
            WriteLine(helloMsg);
        }
        static void SayHelloWithInputs(string msg,
                                        string userName)
        {
            WriteLine(msg + ", " + userName);
        }

        static string GetNameFromUser()
        {
            Write("Enter the user's name: ");
            string userName = ReadLine();
            return userName; //control leaves the method
            //WriteLine("This is the end"); unreachable code because it is after return statement
        }

        static void GetTwoGrades(string userName, out double grade1, out double grade2)
        {
            Write("Enter the grade1 for " + userName + ": ");
            grade1 = double.Parse(ReadLine());
            Write("Enter the grade2 for " + userName + ": ");
            grade2 = double.Parse(ReadLine());
        }

        static double GetMax(double grade1, double grade2)
        {
            return Math.Max(grade1, grade2);
        }

        private static void DisplayBanner(string customerName, double grade1, double grade2, double maxGrade)
        {
            string asterikLine = new string('*', 44);
            WriteLine(asterikLine);
            WriteLine("*{0, 15}: {1, -25}*", "User Name", customerName);
            WriteLine("*{0, 15}: {1, 5:F1}, {2, -18:F1}*", "Grades", grade1, grade2);
            WriteLine("*{0, 15}: {1, -25:F1}*", "Highest Grade", maxGrade);
            WriteLine(asterikLine);
        }


    }
}
