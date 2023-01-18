using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lec3Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            WriteLine("Lec3, Demo 1: Getting numeric grades and find average grade");

            Write("Enter grade 1: ");
            int grade1 = int.Parse(ReadLine());

            Write("Enter grade 2: ");
            int grade2 = int.Parse(ReadLine());

            Write("Enter grade 3: ");
            int grade3 = int.Parse(ReadLine());
            //Excplicit Cast Operator - converts numeric data type to any type
            //(data.type)(value)
            //EX: (double)(5+5+6)/3
            double avg = (grade1 + grade2 + grade3) / 3; //integer division int/int gives an int - we will talk about this next class

            string asterikLine = new string('*', 50);
            
            //output specifiers - N3, F2, C
            // N - number with digit separators
            // F - floating point notation
            // C - Currency
            WriteLine(asterikLine);
            WriteLine("*{0, 20:F2}: {1, -26}*", "Grade 1", grade1);
            WriteLine("*{0, 20}: {1, -26}*", "Grade 2", grade2);
            WriteLine("*{0, 20}: {1, -26}*", "Grade 3", grade3);
            WriteLine("*{0, 20}: {1, -26:N3}*", "Avg Grade", avg);
            WriteLine(asterikLine);
        */
            WriteLine("Lec3, Demo 2: Postfix increment operator");
            Write("Enter your age: ");
            int age1 = int.Parse(ReadLine());
            WriteLine(age1);
        }
    }
}
