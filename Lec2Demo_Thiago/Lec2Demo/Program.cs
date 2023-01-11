using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
            //parsing values
            string string0 = "76";
            WriteLine(string0.GetType());
            int number0 = int.Parse(string0);
            WriteLine(number0.GetType());

            // Declaring main variables
            string asteriskLine = new string('*', 64);
            // Input for Name
            Write("Please enter your name: ");
            string name = ReadLine();
 
            if (name == "")
            {
                WriteLine("Error: Name cannot be null");

            }
            else {
                Write("\n");
                // Input for faculty
                Write("Please enter your faculty : ");
                string faculty = ReadLine();
                Write("\n");
                // Input for department
                Write("Please enter your department : ");
                string dept = ReadLine();
                Write("\n");

                //input grade
                Write("Please enter your grade : ");
                int grade1 = int.Parse(ReadLine());
                

                // Prints the banner

                WriteLine(asteriskLine);
                WriteLine("*{0,20}: {1,-40}*", "Name",name);
                WriteLine("*{0,20}: {1,-40}*", "Faculty", faculty);
                WriteLine("*{0,20}: {1,-40}*", "Department", dept);
                WriteLine(asteriskLine);

            }

        }
    }
}
