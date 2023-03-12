using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TicketProblem
{
    internal class Ticket
    {

        public string StudentID
        {
            get;
            set;
        }
        public char StudentCategory
        {
            get;
            set;
        }
        public int SpeedLimit
        {
            get;
            set;
        }
        public int SpeedReported
        {
            get;
            set;
        }
        public string CategoryName
        {
            get
            {
                switch (StudentCategory)
                {
                    case '1':
                        return "Freshman";
                    case '2':
                        return "Sophmore";
                    case '3':
                        return "Junior";
                    case '4':
                        return "Senior";
                    default:
                        return "Error";
                }


            }

        }
        public double Fine
        {
            get
            {
                double initialTicket = 75;
                double finalTicket = initialTicket;
                int speedOverLimit = (this.SpeedReported - this.SpeedLimit);
                if (this.SpeedReported > this.SpeedLimit + 5)
                {
                    finalTicket += speedOverLimit / 5 * 87.5;
                }
                if (this.StudentCategory == '4' && speedOverLimit < 20)
                {
                    finalTicket += 50;
                }
                else if (this.StudentCategory == '4' && speedOverLimit >= 20)
                {
                    finalTicket += 200;
                }
                else if (this.StudentCategory == '1' && speedOverLimit < 20)
                {
                    finalTicket -= 50;
                }
                if (this.StudentCategory != '4' && speedOverLimit > 20)
                {
                    finalTicket += 100;
                }
                return finalTicket;
            }
        }
        public Ticket(string StudentID, char StudentCategory, int SpeedLimit, int SpeedReported)
        {
            this.StudentID = StudentID;
            this.StudentCategory = StudentCategory;
            this.SpeedLimit = SpeedLimit;
            this.SpeedReported = SpeedReported;
        }
        public override string ToString()
        {
            //ToString() method to display each ticket details including StudentId, StudentCategory, SpeedLimit,
            //SpeedReport, CategoryName and Fine
            string finalPrint = String.Format($"Student ID: {StudentID,-10}\nStudentCategory: {StudentCategory,-10}\nSpeedLimit: {SpeedLimit,-10}\nSpeed Reported: {SpeedReported,-10}\nCategory Name:{CategoryName,-10}\nFine: {Fine,-10:C}");
            return finalPrint;
        }
    }
}
