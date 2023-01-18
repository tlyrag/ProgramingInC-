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
            // ---------------------DEMO 1----------------------------
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
            // 
            WriteLine(asterikLine);
            WriteLine("*{0, 20:F2}: {1, -26}*", "Grade 1", grade1);
            WriteLine("*{0, 20}: {1, -26}*", "Grade 2", grade2);
            WriteLine("*{0, 20}: {1, -26}*", "Grade 3", grade3);
            WriteLine("*{0, 20}: {1, -26:N3}*", "Avg Grade", avg);
            WriteLine(asterikLine);
        */
            // ---------------------DEMO 2----------------------------
            /*
            WriteLine("Lec3, Demo 2: Postfix increment operator");
            Write("Enter your age: ");
            int age1 = int.Parse(ReadLine());
            // formatted output with age1

            // Postfix
            WriteLine("The value of age after with postfix increment is {0}", age1++);
            WriteLine("The value of age after postfix increment is " + age1);
            // Prefix
            Write("Enter your age: ");
            int age2 = int.Parse(ReadLine());
            // formatted output with age1
            WriteLine("The value of age after with prefix increment is {0}", ++age2);
            WriteLine("The value of age after prefix increment is " + ++age2);
            */
            //// ---------------------DEMO 3----------------------------
            /*
            WriteLine("Lec3, Demo 3: conjunctive concatenation");
            string msg = "Hello, ";
 
            msg += "how are you? ";
            msg += "Another msg added here ";
            msg += 5.5;
            WriteLine("Message after all the conjuctive concatenation is {0} ", msg);

            // * - multiplication
            // / - division
            // % modulus opreator ex: 23%5 =3
            // 
            */
            //// ---------------------DEMO 4----------------------------
             WriteLine("Lec3, Demo 4: Methods");

        }

    }
}
