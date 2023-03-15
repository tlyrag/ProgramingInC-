using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            List<string> NamesList = new List<string>(); //constructing an empty list of string with 0 elements to start with
            WriteLine("Total number of names in the list before adding the names = " + NamesList.Count);
            // add = push
            
            NamesList.Add("John"); //this adds John to the end of the list
            NamesList.Add("William");
            NamesList.Add("Jim");
            NamesList.Add("Amy");
            NamesList.Insert(1, "Marie");
            NamesList.Insert(2, "Jim");

            NamesList.Remove("Jim");
            NamesList.RemoveAt(2);


            WriteLine(NamesList);
            //Note that List has Count property but arrays have Length property
            WriteLine("Total number of names in the list = " + NamesList.Count);

            foreach (string name in NamesList)
            {
                Write(name + "\t");
            }
            WriteLine();
            List<double> Numbers = new List<double>() { 2.3,-5,-7,0,1,4,3,2 };
            Numbers.Remove(0);
            foreach(double num in Numbers)
            {
                WriteLine(num);
            }

            List<double> GradeList = new List<double>();

            WriteLine($"Names count: {NamesList.Count}, Grades Count:{GradeList.Count}");
            for(int i= 0; i< NamesList.Count; i++)
            {
                double grade;
                Write($"Enter the grade for {NamesList[i]}: ");
                while(!double.TryParse(ReadLine(),out grade) || grade<0 || grade>100)
                {
                    Write($"Please re enter grade for {NamesList[i]}:");
                }
                GradeList.Add(grade);
                    
            }
            WriteLine($"Names count: {NamesList.Count}, Grades Count:{GradeList.Count}");
            DisplayNamesAndGrade(NamesList, GradeList);
            WriteLine($"The biggest grade was from: {GetNameOfMaxGrade(NamesList, GradeList)}");
        }
        static string GetNameOfMaxGrade(List<string> names, List<double> grades)
        {
            int maxGradeIndex = 0;
            for(int i= 0; i< names.Count; i++)
            {
                if (grades[maxGradeIndex] < grades[i])
                {
                    maxGradeIndex=i;
                }
            }
            string maxName = names[maxGradeIndex];
            return maxName;
        }
        static void DisplayNamesAndGrade (List<string> names,List<double> grades)
        {
            for (int i = 0; i < names.Count; i++)
            {
                WriteLine($"{names[i]} got {grades[i]}");
            }
        }
    }
}
