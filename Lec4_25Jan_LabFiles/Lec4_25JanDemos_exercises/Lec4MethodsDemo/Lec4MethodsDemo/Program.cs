using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lec4MethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Method demo 1: void return type, no input method");
            SayHello();
            SayHello();
            SayHello();
            //WriteLine(helloMsg); //will not work because helloMsg declared inside the method

            WriteLine("Method demo 2: void return type, two string inputs");
            SayHelloWithInputs("Hello", "Amanda");
            string anyMsg = "Welcome";
            string name = "Edward";
            SayHelloWithInputs(anyMsg, name); //arguments - may be literals or variables
            //input parameter => value of the argument goes into the parameter
            WriteLine(name); //argument is available main method
            //WriteLine(userName); //parameter from method cannot be accessed outside

            WriteLine("Method demo 3: Value-returning, no input method");
            string customerName = GetNameFromUser();
            SayHelloWithInputs("Have a good day", customerName);

            SayHelloWithInputs("Hi ", customerName + "! Welcome to the high grade calculator");
            //out arguments - must be variables
            double gradeOne;
            GetTwoGrades(customerName, out gradeOne, 
                                        out double gradeTwo);
            WriteLine("Grades are {0} and {1}",gradeOne,gradeTwo);

            double maxGrade = GetMax(gradeOne, gradeTwo);

            DisplayBanner(customerName, gradeOne, gradeTwo, maxGrade);

            //Practice Exercise: Create/define a method (outside
            //the main method) that is void method with string input
            //parameter and out string parameter 
            //GetName(string nameType, out string name)
            //This method takes as input nameType either "first"
            //or "last" and then asks user for Enter first/last name
            //...sets the out parameter for first/last
            //You will then call this method in the main method
            //twice for getting out first and last name
            //Then display it as "Last name", "First Name"

        }
        static void SayHello()
        {
            string helloMsg = "Hi, Priya!"; //variable is local to this method
            WriteLine(helloMsg);
        }
        static void SayHelloWithInputs(string msg,
                                        string userName)
        {
            //parameters only available inside the method definition
            //and is used everytime the method is called
            //to execute the method based on the input parameters
            WriteLine(msg + "**********" + userName);
        }

        static string GetNameFromUser() //no input parameters, string value returning method
        {
            Write("Enter the user's name: ");
            string userName = ReadLine(); //userName - local variable
            return userName; //control leaves the method
           // WriteLine("This is the end"); //unreachable code because it is after return statement
        }

        static void GetTwoGrades(string userName, out double grade1, 
                                                out double grade2)
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

        private static void DisplayBanner(string customerName, 
            double grade1, double grade2, double maxGrade)
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
