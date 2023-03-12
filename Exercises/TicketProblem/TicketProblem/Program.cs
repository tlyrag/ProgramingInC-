using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TicketProblem

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor Call -> ClassName object = new ClassName(parameters); Ex:
            CheatSheet sheet = new CheatSheet(1);

            // regular methods
            bool loopFlag = true;
            while (loopFlag)
            {
                GetTicketDetails(out string studentId, out char studentCat, out int speedLimit, out int speedReported);
                Ticket ticket1 = new Ticket(studentId, studentCat, speedLimit, speedReported);
                WriteLine(ticket1);
                WriteLine("Do you have another Ticket to enter? Please Enter yes or no");
                string userResponse = ReadLine();
                
                while (userResponse != "yes" && userResponse!= "no")
                {
                    WriteLine("Please Enter yes or no:");
                    userResponse = ReadLine();
                }
                if (userResponse == "no")
                {
                    loopFlag = false;
                } 
            }


        }
        static void GetTicketDetails(out string studentId, out char studentCat, out int speedLimit, out int speedReported)
        {
            studentId = "";
            while (studentId == "")
            {
                Write("Please enter StudentID:");
                studentId = ReadLine();
            };
            Write("Please Enter Student Category: ");
            char[] options = { '1', '2', '3', '4' };
           
            while (!char.TryParse(ReadLine(), out studentCat) || Array.IndexOf(options,studentCat) < 0)
            {
                Write("Please Enter a Valid Student Category 1,2,3 or 4: ");
            }
       
            Write("Please enter Speed Limit: ");
            while (!int.TryParse(ReadLine(), out speedLimit) || speedLimit < 0)
            {
                Write("Please enter a valid Speed Limit: ");
            }
            Write("Please enter Speed Reported: ");
            while (!int.TryParse(ReadLine(), out speedReported) || speedLimit < 0)
            {
                Write("Please enter a valid Speed Reported: ");
            }
        }
    }
}
