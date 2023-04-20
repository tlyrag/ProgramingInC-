using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    internal class Students
    {
        public string StudentId { get; set; }   
        public string StudentFirstName { get; set;}
        public string StudentLastName { get; set;}
        public double QuizzScore { get; set;}
        public double MidtermScore { get; set;} 
        public double FinalsScore { get; set;}
        public double FinalGrade { 
            get {
                double finalGrade = (this.QuizzScore/50 * 20) + (this.MidtermScore/50 * 30) + (this.FinalsScore/100 * 50);
                return finalGrade;
             } 
        }
        public string systemGrade { get
            {
                if (this.FinalGrade > 95)
                {
                    return "A+";
                }
                else if (this.FinalGrade > 90)
                {
                    return "A";
                }
                else if (this.FinalGrade > 85)
                {
                    return "A-";
                }
                else if (this.FinalGrade > 80)
                {
                    return "B+";
                }
                else if (this.FinalGrade > 75)
                {
                    return "B";
                }
                else if (this.FinalGrade > 70)
                {
                    return "B-";
                }
                else if (this.FinalGrade > 65)
                {
                    return "C+";
                }
                else if (this.FinalGrade > 60)
                {
                    return "C";
                }
                else if (this.FinalGrade > 55)
                {
                    return "C-";
                }
                else if (this.FinalGrade > 50)
                {
                    return "C-";
                }
                else
                {
                    return "F";
                }

            }
        }
        public Students(string studentId, string studentFirstName, string studentLastName, double quizzScore, double midtermScore, double finalsScore)
        {
            this.StudentId = studentId;
            this.StudentFirstName = studentFirstName;
            this.StudentLastName = studentLastName;
            this.QuizzScore = quizzScore;
            this.MidtermScore = midtermScore;
            this.FinalsScore = finalsScore;
        }
        public override string ToString()
        {
            string student = $"{this.StudentId,-15}{this.StudentFirstName,-15}{this.StudentLastName,-15}{this.QuizzScore,-15}{this.MidtermScore,-15}{this.FinalsScore,-15}{this.FinalGrade,-15}{this.systemGrade,-15}";
            return student;
        }
    }
}
