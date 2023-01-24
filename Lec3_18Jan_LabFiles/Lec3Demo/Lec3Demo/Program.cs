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

            double avg = ((double)grade1 + grade2 + grade3) / 3; //integer division int/int gives an int - we will talk about this next class
            //explicit cast operator - converts one numeric data type to another
            string asterikLine = new string('*', 50);
            WriteLine(asterikLine);
            WriteLine("*{0, 20}: {1, -26:F2}*", "Grade 1", grade1);
            WriteLine("*{0, 20}: {1, -26}*", "Grade 2", grade2);
            WriteLine("*{0, 20}: {1, -26}*", "Grade 3", grade3);
            WriteLine("*{0, 20}: {1, -26:F2}*", "Avg Grade", avg);
            WriteLine(asterikLine);

            //output specifiers - N3, F2, C
            //N - number with digit separators
            //F - floting point notation
            //C - Currency
            //Change locale settings in C# code - can be done
            WriteLine("Lec3, Demo 2: Postfix increment operator");
            Write("Enter your age: ");
            int age1 = int.Parse(ReadLine());
            //formatted output with age1
            WriteLine("The value of age with postfix increment is {0}",age1++);
            //unformatted output with concatenation -> + 
            WriteLine("The value after postfix statement is " + age1);

            WriteLine("Lec3, Demo 2: Prefix increment operator");
            Write("Enter your age: ");
            int age2 = int.Parse(ReadLine());
            //formatted output with age2
            WriteLine("The value of age with prefix increment is {0}", ++age2);
            //unformatted output with concatenation -> + 
            WriteLine("The value after prefix statement is " + age2);

            WriteLine(2 + 3 + 5);
            WriteLine("2" + "3");
            WriteLine("2" + 3 + 5); //it automatically converts 3 to stirng "3"
            WriteLine("2" + (3 + 5));

            WriteLine("Lec 3, Demo 3: conjunctive concatenation");
            string msg = ""; //"" - empty string literal, not null
            msg += "How are you?";
            msg += "Another msg added here ";
            msg += 5.5;
            WriteLine("Message after all " +
                "the conjunctive concatenations is " + msg)
             

            // * - multiplication
            // / - division
            //% - modulus operator 23 % 5 = 3 - gives remainder after division
            */


            //Practice Exercise 1: If using double grades for avg calculator
             //double grade1 = double.Parse(ReadLine());
            //similarly, grade2, and grade3
            //no casting needed in that case
            //Try average grade calculator with double grades instead 
            //of int

            //Practice Exercise 2: Try Postfix and Prefix Decrement operator
            //and see how it works.
            /*int number1 = 1;
            int number2 = 1;
            string dash = new string('-', 20);
            WriteLine("This is postfix the value with the decrement operator {0}",number1--);
            WriteLine("This is the value after the operation {0}", number1);
            WriteLine(dash);
            WriteLine("This is prefix the value with the decrement operator {0}", --number2);
            WriteLine("This is the value after the operation {0}", number2);*/

            //Conjunctive addition and subtraction works with numbers just like 
            //conjunctive concatenation
            //Practice Exercise 3: try using conjunctive addition and subtraction and displaying 
            //the value and see what it does
            int number3 = 5;
            WriteLine(number3 += 3);    
            WriteLine(number3);
            WriteLine(number3-=3);
            WriteLine(number3);

            //Practice Exercise 4: Try increment and decrement operator
            //with double and see how it works.
            int number4 = 9;
            double number5 = (double)(number4)/4;
            WriteLine(++number5);
            WriteLine(number5);

            //PRACTICE EXERCISE 5: 
            //Please try creating the Carpet Calculator app on Pg 116 only using pre-defined method in the main program
            //CarpetCalculatorApp gets from user length and width in feet and inches as int for each and also gets carpet cost in double $ per sq. yd. 
            //for two different types of carpet (Pile and Berber). 
            //Using length feet and inches you will compute length double value in ft (using 12 inches = 1 ft conversion)
            //Then compute area in sq. ft by multiplying length and width in feet
            //Then compute area in sq. yds by dividing the area in sq. ft / 9 -> 9 sq. ft = 1 sq. yd
            //Then compute carpet total cost for Pile carpet type by multiple PileCostPerSqYd*AreaInSqft
            //Then compute carpet total cost for Berber carpet type by multiplying BerberCostPerSqYd*AreaInSqFt
            //Display using output banner, the length in ft and inches, width in ft and inches, Pile Cost per sq. yd,
            //Berber Cost per sq. yd, Pile Total Cost, Berber Total Cost

            //We will do this demo with methods, but you must try this demo without user-defined methods
            //so that you understand the problem next week



            WriteLine("Press any key to continue...");
            ReadKey(); //reads one character/keyboard entry

        }
    }
}
