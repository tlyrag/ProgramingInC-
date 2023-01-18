using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lec2Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WriteLine("************************");
            WriteLine("*     Name: Priya      *");
            WriteLine("*  Faculty: CBA        *");
            WriteLine("*     Dept: CSIS       *");
            WriteLine("************************");

            WriteLine("Lec 2: Demo with user input and output");
            Write("Enter your name: ");
            string userName = ReadLine();
            WriteLine("Name is " + userName);

            Write("Enter your faculty: ");
            string faculty = ReadLine();

            Write("Enter your dept: ");
            string dept = ReadLine();

            WriteLine("***********************************");
            WriteLine("*     Name: " + userName + "      *");
            WriteLine("*  Faculty: " + faculty + "       *");
            WriteLine("*     Dept: " + dept + "          *");
            WriteLine("***********************************");

            string asterikLine = new string('*', 64);
            WriteLine(asterikLine);
            WriteLine("*{0, 20}: {1, -40}*","Name",userName);
            WriteLine("*{0, 20}: {1, -40}*", "Faculty", faculty);
            WriteLine("*{0, 20}: {1, -40}*", "Dept", dept);
            WriteLine(asterikLine);

            
            int number = int.Parse("76"); //as input - string, returns int
            double numberD = double.Parse("56.5");

            WriteLine("Next demo..working with numbers in user input");
            WriteLine("Number = " + number);
            Write("Enter grade 1: ");
            int grade1 = int.Parse(ReadLine());
            
            //Practice Exercise 1: Create a banner with 30 characters for fieldname
            //and 40 characters for field values, and use ---- for horizontal line
            //and | symbol for lines 2, 3 and 4 for left and right edges
            string borderLine = new string('-', 74);
            WriteLine(borderLine);
            WriteLine("|{0,30}: {1,-40}|","Name",userName);
            WriteLine("|{0,30}: {1,-40}|", "Faculty", faculty);
            WriteLine("|{0,30}: {1,-40}|", "Department", dept);
            WriteLine(borderLine);

            //Practice Exercise 2: Similar to grade1, get grade input from console input
            //for grade2 and grade3.
            //Display the name, faculty, dept, grade1, grade2, and grade3
            //using a output banner with formatted output - any length of your choice
            Write("Please enter Grade2: ");
            string grade2 = ReadLine();
            
            Write("Please enter Grade2: ");
            string grade3 = ReadLine();

            string borderLine2 = new string('-', 74);
            WriteLine(borderLine2);
            WriteLine("|{0,30}: {1,-40}|", "Name", userName);
            WriteLine("|{0,30}: {1,-40}|", "Faculty", faculty);
            WriteLine("|{0,30}: {1,-40}|", "Grade1", grade1);
            WriteLine("|{0,30}: {1,-40}|", "Grade2", grade2);
            WriteLine("|{0,30}: {1,-40}|", "Grade3", grade3);
            WriteLine(borderLine2);

            //Additional challenge practice exercise 3:
            //declare a double variable called avg
            //and find the average of grade1, grade2 and grade3
            //and store it in avg - e.g.,
            //double avg = (grade1 + grade2 + grade3)/3
            
             double avg = (grade1  + int.Parse(grade2) + int.Parse(grade3))/3;

            WriteLine(avg);
            //Update your output banner to display the average as well
            //End of the slides in Lec2 also has additional practice exercise to try
            //Review book chapters 1 and 2 for overall concept understanding

            //Additional Notes: 
            WriteLine("Hello\n");
            Write("Hello\n\n"); //\n - newline character

            //username - all lower case
            //USERNAME - all upper case, not used for variables
            //UserName - Pascal Case - first letter upper case in eachword
            //userName - first word all lower case, second word on, first letter is upper case
            //primitive data type variables such as
            //string, int, double, decimal and char use camelCase in variable
            //name as a convention
        }
    }
}
