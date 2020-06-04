using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  OO 06-04-2020

  Task
  ----------------------------------------------------------------------------------------------------------
  Given an integer, , perform the following conditional actions:
  If 'n' is odd, print Weird
  If 'n' is even and in the inclusive range of 2 to 5, print Not Weird
  If 'n' is even and in the inclusive range of 6 to 20, print Weird
  If 'n' is even and greater than 20, print Not Weird
  Complete the stub code provided in your editor to print whether or not  is weird.

  Input Format
  ----------------------------------------------------------------------------------------------------------
  A single line containing a positive integer, 'n'.

  Sample Input
  ----------------------------------------------------------------------------------------------------------
  3

  Sample Output
  ----------------------------------------------------------------------------------------------------------
  Weird

*/

namespace Day03_IntroConditionalStatements
{
    class Program
    {
        static string WeirdOrNot(int number)
        {
            if (number % 2 != 0)
            {
                return "Weird";
            }
            else
            {
                if (number >= 2 && number <= 5)
                {
                    return "Not Weird";
                }
                else if (number >= 6 && number <= 20)
                {
                    return "Weird";
                }
                else
                {
                    return "Not Weird";
                }
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(WeirdOrNot(n));
        }
    }
}
