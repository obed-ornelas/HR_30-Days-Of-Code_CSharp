using System;

/*
  OO 06-17-2020

  Context
  ----------------------------------------------------------------------------------------------------------
  Given a 6x6 2D Array, A

  1 1 1 0 0 0
  0 1 0 0 0 0
  1 1 1 0 0 0
  0 0 0 0 0 0
  0 0 0 0 0 0
  0 0 0 0 0 0

  We define an hourglass in A to be a subset of values with indices falling in this pattern in A's graphical representation:

  a b c
    d
  e f g

  There are 16 hourglasses in A, and an hourglass sum is the sum of an hourglass' values.

  Task
  ----------------------------------------------------------------------------------------------------------
  Calculate the hourglass sum for every hourglass in A, then print the maximum hourglass sum.

  Input Format
  ----------------------------------------------------------------------------------------------------------
  There are 6 lines of input, where each line contains 6 space-separated integers describing 2D Array A;
  every value in A will be in the inclusive range of -9 to 9.
*/

namespace Day11_2DArrays
{
    class Program
    {
        static int GetHourGlassSum(int[][] map, int x, int y)
        {
            int sum = map[x - 1][y - 1] +
                      map[x - 1][y] +
                      map[x - 1][y + 1] +
                      map[x][y] +
                      map[x + 1][y - 1] +
                      map[x + 1][y] +
                      map[x + 1][y + 1];

            return sum;
        }

        static int FindMaxHourGlassSum(int[][] map)
        {
            int maxSum = 0;

            for (int row = 1; row < map.Length - 1; row++)
            {
                for (int col = 1; col < map.Length - 1; col++)
                {
                    int sum = GetHourGlassSum(map, row, col);

                    if (row == 1 && col == 1 || sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            return maxSum;
        }

        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            Console.WriteLine(FindMaxHourGlassSum(arr));
            Console.ReadLine();
        }
    }
}
