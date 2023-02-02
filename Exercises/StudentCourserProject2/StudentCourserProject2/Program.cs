using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudentCourserProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course firstStud = new Course(1775,"Thiago");
            firstStud.finalGrade = FinalGradeCalc(13,13,10,10,8,8);
            firstStud.IsApproved();
            WriteLine(firstStud);
           
        }
        public static double FinalGradeCalc(double quizz1, double quizz2, double assign1, double assign2, double midTerm, double final)
        {
            double finalGrade;
            finalGrade = (quizz1 * 7.5 / 15) + (quizz2 * 7.5 / 15) + assign1 + assign2 + midTerm * 3 + final * 3.5;
            return finalGrade;
        }
        
    }
}
