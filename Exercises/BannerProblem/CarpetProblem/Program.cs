using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarpetProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Write("Please select the Horizontal banner char: ");
                char horBorderChar = char.Parse(ReadLine());
                Write("Please select the Vertical banner char: ");
                char verBorderChar = char.Parse(ReadLine());
                printBorder(horBorderChar);
                printLine01(verBorderChar);
                printLine23(verBorderChar);
                printLine45(verBorderChar);
                printLine67(verBorderChar);
                printLine89(verBorderChar);
                printBorder(horBorderChar);
            }
            catch
            {
                WriteLine("Char must only contain one line, please try it again");
            }
        }
        private static void printBorder(char borderChar) {  
                String border = new string(borderChar, 50);
                WriteLine(border);             
        }
        //first two initial lines
        private static void printLine01(char verBorderChar) {
            
            String T = new string('T', 14);
            String L = new string('L', 2);
            String G = new string('G', 12);
            WriteLine("{4} {1,14}{0,4}{2,2}{0,14}{3,8} {4}","",T,L,G, verBorderChar);
            WriteLine("{4} {1,14}{0,4}{2,2}{0,14}{3,8} {4}", "",T, L, G, verBorderChar);
        }
        private static void printLine23(char verBorderChar)
        {
            String T = new String('T',2);
            String L = new String('L',2);
            String G = new String('G',2);
            WriteLine("{4} {1,6}{0,2}{1,10}{2,2}{1,14}{3,-12} {4}", T, " ", L, G,verBorderChar);
            WriteLine("{4} {1,6}{0,2}{1,10}{2,2}{1,14}{3,-12} {4}", T, " ", L, G,verBorderChar);
        }
        private static void printLine45(char verBorderChar)
        {
            String T = new String('T', 2);
            String L = new String('L', 2);
            String FirstG = new String('G', 2);
            String SecondG = new String('G', 6);
            WriteLine("{5} {1,6}{0,2}{1,10}{2,2}{1,14}{3,-2}{1,4}{4,-6} {5}", T, " ", L, FirstG,SecondG,verBorderChar);
            WriteLine("{5} {1,6}{0,2}{1,10}{2,2}{1,14}{3,-2}{1,4}{4,-6} {5}", T, " ", L, FirstG,SecondG,verBorderChar);
        }
        private static void printLine67(char verBorderChar)
        {
            String T = new String('T', 2);
            String L = new String('L', 2);
            String G = new String('G', 2);
            WriteLine("{4} {1,6}{0,2}{1,10}{2,2}{1,14}{3,-2}{1,8}{3,-2} {4}", T, " ", L, G,verBorderChar);
            WriteLine("{4} {1,6}{0,2}{1,10}{2,2}{1,14}{3,-2}{1,8}{3,-2} {4}", T, " ", L,G,verBorderChar);
        }
        private static void printLine89(char verBorderChar)
        {
            String T = new String('T', 2);
            String L = new String('L', 12);
            String G = new String('G', 12);
            WriteLine("{4} {1,6}{0,2}{1,10}{2,12}{1,4}{3,12} {4}", T, " ", L, G,verBorderChar);
            WriteLine("{4} {1,6}{0,2}{1,10}{2,12}{1,4}{3,12} {4}", T, " ", L,G, verBorderChar);
        }
    }
}
