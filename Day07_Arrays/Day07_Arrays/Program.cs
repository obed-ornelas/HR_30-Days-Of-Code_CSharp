using System;

/*
  OO 06-04-2020

  Task
  ----------------------------------------------------------------------------------------------------------
  Given an array, A, of N integers, print A's elements in reverse order as a single line of space-separated
  numbers.

  Input Format
  ----------------------------------------------------------------------------------------------------------
  The first line contains an integer, N (the size of our array).
  The second line contains N space-separated integers describing array A's elements.

  Sample Input
  ----------------------------------------------------------------------------------------------------------
  4
  1 4 3 2

  Sample Output
  ----------------------------------------------------------------------------------------------------------
  2 3 4 1

*/

namespace Day07_Arrays
{
    class Program
    {
        static int[] Reverse(int[] array)
        {
            int size = array.Length;
            int[] reversed = new int[size];

            for (int i = size - 1, j = 0; i >= 0; i--, j++)
            {
                reversed[j] = array[i];
            }

            return reversed;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));

            Console.WriteLine(string.Join(" ", Reverse(array)));

            Console.ReadLine();
        }
    }
}
