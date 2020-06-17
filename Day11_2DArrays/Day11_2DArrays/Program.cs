using System;

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
