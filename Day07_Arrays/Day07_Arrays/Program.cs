using System;

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
