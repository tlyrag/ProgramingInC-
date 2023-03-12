using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TicketProblem

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining Initial Variabls
        
        
            Ticket[] tickets = new Ticket[99999];    // Infinit number of tickets

            bool loopFlag = true; // boolean to check if we should stop asking for user Ticket Input
            int ticketNumber = 0; // Number of tickets entered in the console
            string border = new string('*', 50); // border used to log in console
            
            while (loopFlag)
            {

                GetTicketDetails(out string studentId, out char studentCat, out int speedLimit, out int speedReported); // Get user inputs
                tickets[ticketNumber] = new Ticket(studentId, studentCat, speedLimit, speedReported); // add the user input to the current arrayindex starting at 0
               
                // Ploting Current Ticket Details
                WriteLine(border);
                WriteLine(tickets[ticketNumber]);
                WriteLine(border);
                
                ticketNumber++; // increase array index
                
                // Checking for other inputs
                WriteLine("Do you have another Ticket to enter? Please Enter yes or no");
                string userResponse = ReadLine().ToLower();
                // Testing user input is yes or no
                while (userResponse != "yes" && userResponse!= "no")
                {
                    WriteLine("Please Enter yes or no:");
                    userResponse = ReadLine();
                }
                // Leave loop if user answers no
                if (userResponse == "no")
                {
                    loopFlag = false; //change flag to leave loop
                    ticketNumber--; // adjust ticket number to the index of the las item added
                }
            }
            WriteLine("The quantity of tickets entered is:" + ticketNumber+1);
            
            // I had to create a new array with the amount of tickets entered. Otherwise, the GetMinMax function would result in an error
            // Due to trying to calculate an unassigned values.

            Ticket[] finalTicket = new Ticket[ticketNumber];
            for(int i = 0;i< finalTicket.Length;i++)
            {   
                finalTicket[i] = tickets[i];
            }
            
            GetMinMaxTicketFineIndex(finalTicket, out int[] minMaxIndex); // if I use here the tickets as argument 

            
            WriteLine(border);
            WriteLine("Minimum Ticket Details:");
            WriteLine(finalTicket[minMaxIndex[0]]);
            
            WriteLine(border);
            WriteLine("Maximum Ticket Details:");
            WriteLine(finalTicket[minMaxIndex[1]]);
            
            WriteLine(border);
            double averageTicketFIne = GetAverageTicketFine(finalTicket);
            WriteLine($"The average ticket Fine is:${averageTicketFIne:c}");


        }
        // Get ticket details from user input
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

        // Calculate the average of tickets entered by the user
        static double GetAverageTicketFine(Ticket[] anyTicket)
        {
            double sum = 0;
            double average;
            foreach(Ticket ticket in anyTicket)
            {
                int counter = 1;
                sum += ticket.Fine;
                counter++;
            }
            average= sum/anyTicket.Length;
            return average;
        }

        // Get the index of the minimum and maximum Fine values
        static void GetMinMaxTicketFineIndex(Ticket[] anyTicket, out int[] minMaxIndex)
        {
            minMaxIndex = new int[2]; // Creating new MinMax array
            

            int minStudIndex = 0;
            int maxStudIndex = 0;

            // assigning min and max values to test
            double min = anyTicket[0].Fine; 
            double max = anyTicket[0].Fine;

            // Loop through array to check for Min and Max and grab the IndexOf them
            for (int i=0; i<anyTicket.Length;i++)
            {
                WriteLine("Ticket: " + i);
                if (anyTicket[i].Fine < min) {
                    minStudIndex= i;
                } else if (anyTicket[i].Fine > max)
                {
                    maxStudIndex= i;
                }
            }
            minMaxIndex[0] = minStudIndex;
            minMaxIndex[1] = maxStudIndex;

        }
    }

}
