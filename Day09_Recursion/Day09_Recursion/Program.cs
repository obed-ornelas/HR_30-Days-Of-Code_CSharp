using System;
using System.IO;

/*
  OO 06-07-2020

  Task
  ----------------------------------------------------------------------------------------------------------
  Write a factorial function that takes a positive integer, 'N' as a parameter and prints the result of N!
  (N factorial).

  Input Format
  ----------------------------------------------------------------------------------------------------------
  A single integer, N (the argument to pass to factorial).

  Sample Input
  ----------------------------------------------------------------------------------------------------------
  3

  Sample Output
  ----------------------------------------------------------------------------------------------------------
  6

*/

namespace Day09_Recursion
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("OUTPUT.txt", true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = Factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
