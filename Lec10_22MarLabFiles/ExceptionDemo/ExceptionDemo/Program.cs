
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get interger input - parse using Parse method
            //out of range
            // 
            try
            {
                Write("Enter the denominator: ");
                int denominator = int.Parse(ReadLine());
                WriteLine("This statement will be executed after the parse");
                double[] numbers = { 43, 76, 89, 92 };
                double[] results = new double[numbers.Length];

                for(int i = 0; i <= numbers.Length; i++)
                {
                    results[i] = numbers[i]/denominator;
                    WriteLine($"Result of ith element = {results[i]}");
                }

            } catch(IndexOutOfRangeException err) {
                WriteLine(err.Message + " Index out of bound error");
            }
            
            catch(DivideByZeroException err) 
            {
                WriteLine(err.Message + " Check if the denominator is 0");
            }
            catch(FormatException err)
            {
                WriteLine(err.Message +"Check denominator integer input or fomat pattern");
            }
            catch (Exception err)
            {
                WriteLine(err.Message  + " This is an error");
            } finally
            {
                WriteLine("Always executed");
            }
          
        }
       
    }
}
