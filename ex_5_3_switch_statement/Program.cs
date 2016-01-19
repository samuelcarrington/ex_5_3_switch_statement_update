using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5_3_switch_statement
{
    class Program
    {
        static void Main()
        {
            /*	5-3	Write a program that asks for a digit (0-9), 
                and depending on the input, shows the digit as a word(in English). 
                Use a switch statement. (Chapter 5, Exercise 5) */

            Console.WriteLine("Enter an interger between (0-9)");
            int Num = int.Parse(Console.ReadLine());
            switch (Num)
            {
                case 0:
                    Console.WriteLine("Zero"); break;
                case 1:
                    Console.WriteLine("One"); break;
                case 2:
                    Console.WriteLine("Two"); break;
                case 3:
                    Console.WriteLine("Three"); break;
                case 4:
                    Console.WriteLine("Four"); break;
                case 5:
                    Console.WriteLine("Five"); break;
                case 6:
                    Console.WriteLine("Six"); break;
                case 7:
                    Console.WriteLine("Seven"); break;
                case 8:
                    Console.WriteLine("Eight"); break;
                case 9:
                    Console.WriteLine("Nine"); break;
                default:
                    Console.WriteLine("Unknown number!"); break;
            }
        }
    }
}
