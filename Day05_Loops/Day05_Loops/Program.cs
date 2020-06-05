using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  OO 06-04-2020

  Task
  ----------------------------------------------------------------------------------------------------------
  Given an integer, 'n', print its first 10 multiples. Each multiple n x 1 (where i <= i <= 10) should be
  printed on a new line in the form: 'n x 1 = result'

  Input Format
  ----------------------------------------------------------------------------------------------------------
  A single integer, 'n'.

  Sample Input
  ----------------------------------------------------------------------------------------------------------
  2

  Sample Output
  ----------------------------------------------------------------------------------------------------------
  2 x 1 = 2
  2 x 2 = 4
  2 x 3 = 6
  2 x 4 = 8
  2 x 5 = 10
  2 x 6 = 12
  2 x 7 = 14
  2 x 8 = 16
  2 x 9 = 18
  2 x 10 = 20

*/

namespace Day05_Loops
{
    class Program
    {
        static void printFirst10Multiples(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            printFirst10Multiples(n);

            Console.ReadLine();
        }
    }
}
