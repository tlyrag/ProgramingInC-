using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudentAppWithAutoProp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student firstStudentObject = new Student();
            GetStudentName(out string firstName, out string lastName);

            firstStudentObject.StudentFirstName = firstName;
            firstStudentObject.StudentLastName = lastName;
            firstStudentObject.Major = GetMajor();
            firstStudentObject.Grade1 = GetGrade(1);
            firstStudentObject.Grade2 = GetGrade(2);
            firstStudentObject.Grade3 = GetGrade(3);

            WriteLine("First Student");
            WriteLine(firstStudentObject.ToString());


            WriteLine("\n\nSecond student: Using 1-parameter constructor to set student id");
            Student secondStudentObject = new Student(GetStudentId());
            secondStudentObject.Grade1 = 95;
            secondStudentObject.Grade2 = 62;
            secondStudentObject.Grade3 = 87;
            WriteLine("\n\nSecond Student");
            WriteLine("Student Number: " + secondStudentObject.StudentId +
                               "\nAverage: {0:F1}", secondStudentObject.CalculateAverage());

            WriteLine("\n\nThird student: Using 3 parameter constructor");
            Student thirdStudentObject = new Student("5432", "Randolph", "Wonder");
            thirdStudentObject.Major = "Math";
            thirdStudentObject.Grade1 = 95;
            thirdStudentObject.Grade2 = 87;
            thirdStudentObject.Grade3 = 72;
            WriteLine("\n\nThird Student");
            WriteLine(thirdStudentObject);


            WriteLine("\n\nFourth Student: setting 6 properties for the object with constructor");
            Student fourthStudentObject = new Student("1234", "Maria", "Smith", 97, 75, 87, "CS");
            WriteLine("\n\nFourth Student");
            WriteLine(fourthStudentObject);



            WriteLine("\n\nFifth Student: passing objects as parameter for methods..");
            Student fifthStudentObject = new Student(GetStudentId());

            WriteLine("Looking at fifth student details after id is set...");
            WriteLine(fifthStudentObject);

            WriteLine("Npw let us pass this object to Load Student Details method and see what happens to the argument object...");
            LoadStudentDetails(fifthStudentObject);
            WriteLine("\n\nFifth Student after method is executed.....argument object properties values have changed now...");
            WriteLine(fifthStudentObject);

            Write("Enter the student number you would like to view (1/2/3/4/5): ");
            int option = int.Parse(ReadLine());

            if (option == 1)
            {
                WriteLine("Here are the details for Student " + option);
                WriteLine(firstStudentObject);
            }
            else if (option == 2)
            {
                WriteLine("Here are the details for Student " + option);
                WriteLine(secondStudentObject);
            }
            else if (option == 3)
            {
                WriteLine("Here are the details for Student " + option);
                WriteLine(thirdStudentObject);
            }
            else if (option == 4)
            {
                WriteLine("Here are the details for Student " + option);
                WriteLine(fourthStudentObject);
            }
            else if (option == 5)
            {
                WriteLine("Here are the details for Student " + option);
                WriteLine(fifthStudentObject);
            }
            else
            {
                WriteLine("Student view options can only 1, 2, 3 or 4");
            }
        }
        private static void LoadStudentDetails(Student fifthStudentObject)
        {
            string fName, lName;
            GetStudentName(out fName, out lName);
            fifthStudentObject.StudentFirstName = fName;
            fifthStudentObject.StudentLastName = lName;
            fifthStudentObject.Major = GetMajor();
            fifthStudentObject.Grade1 = GetGrade(1);
            fifthStudentObject.Grade2 = GetGrade(2);
            fifthStudentObject.Grade3 = GetGrade(3);
        }

        static int GetGrade(int gradeNumber)
        {
            Write("Enter a value for Grade {0}:", gradeNumber);
            int grade = int.Parse(ReadLine());
            return grade;
        }

        static void GetStudentName(out string studFirstName, out string studLastName)
        {
            Write("Enter Student First Name: ");
            studFirstName = ReadLine();
            Write("Enter Student Last Name: ");
            studLastName = ReadLine();
        }
        static string GetMajor()
        {
            Write("Enter Major: ");
            string major = ReadLine();
            return major;
        }
        static string GetStudentId()
        {
            Write("Enter Student Id: ");
            string id = ReadLine();
            return id;
        }


    }
}
