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
            // Declaring main variables

            string border = "************************";
            // Input for Name
            Write("Please enter your name: ");
            string name = ReadLine();
            Write("\n");
            // Input for faculty
            Write("Please enter your faculty : ");
            string faculty = ReadLine();
            Write("\n");
            // Input for readline
            Write("Please enter your department : ");
            string dept = ReadLine();
            Write("\n");
            WriteLine(border);
            WriteLine($"*   Name: {name}      *");
            WriteLine($"*   Faculty:{faculty}      *");
            WriteLine($"*   Dept:{dept}        *");
            WriteLine(border);
        }
    }
}
