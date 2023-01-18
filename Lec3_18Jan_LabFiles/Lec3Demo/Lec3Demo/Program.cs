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
            WriteLine("Lec3, Demo 1: Getting numeric grades and find average grade");

            Write("Enter grade 1: ");
            int grade1 = int.Parse(ReadLine());

            Write("Enter grade 2: ");
            int grade2 = int.Parse(ReadLine());

            Write("Enter grade 3: ");
            int grade3 = int.Parse(ReadLine());

            double avg = (grade1 + grade2 + grade3) / 3; //integer division int/int gives an int - we will talk about this next class

            string asterikLine = new string('*', 50);
            WriteLine(asterikLine);
            WriteLine("*{0, 20}: {1, -26}*", "Grade 1", grade1);
            WriteLine("*{0, 20}: {1, -26}*", "Grade 2", grade2);
            WriteLine("*{0, 20}: {1, -26}*", "Grade 3", grade3);
            WriteLine("*{0, 20}: {1, -26}*", "Avg Grade", avg);
            WriteLine(asterikLine);
        }
    }
}
