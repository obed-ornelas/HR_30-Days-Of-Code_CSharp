using System;

/*
  OO 06-04-2020

  Task
  ----------------------------------------------------------------------------------------------------------
  Given a string, S, of length N that is indexed from 0 to N - 1, print its even-indexed and odd-indexed
  characters as 2 space-separated strings on a single line (see the Sample below for more detail).

  Input Format
  ----------------------------------------------------------------------------------------------------------
  The first line contains an integer, T (the number of test cases).
  Each line i of the T subsequent lines contain a String, S.

  Sample Input
  ----------------------------------------------------------------------------------------------------------
  2
  Hacker
  Rank

  Sample Output
  ----------------------------------------------------------------------------------------------------------
  Hce akr
  Rn ak
*/

namespace Day06_Review
{
    class Program
    {
        static string ParseEvenOddIndexChars(string input)
        {
            string evenChars = "";
            string oddChars = "";

            for(int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenChars += input[i];
                } else
                {
                    oddChars += input[i];
                }
            }

            return $"{evenChars} {oddChars}";
        }

        static void Main(string[] args)
        {
            int tests = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < tests; i++){
                Console.WriteLine(ParseEvenOddIndexChars(Console.ReadLine()));
            }

            Console.ReadLine();
        }
    }
}
