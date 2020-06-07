using System;

namespace Day10_BinaryNumbers
{
    class Program
    {
        static int CountConsecutiveNumber(int number, string binaryNumber)
        {
            int max = 0, currentMax = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (Int32.Parse(binaryNumber[i].ToString()) == number)
                {
                    currentMax++;

                    if (currentMax > max)
                    {
                        max = currentMax;
                    }
                }
                else
                {
                    currentMax = 0;
                }
            }

            return max;
        }

        static string ToBinary(int number)
        {
            int dividend = number, remainder;
            string binary = "";

            while (dividend > 0)
            {
                remainder = dividend % 2;
                binary = remainder.ToString() + binary;
                dividend = dividend / 2;
            }

            return binary;
        }

        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CountConsecutiveNumber(1, ToBinary(number)));

            Console.ReadLine();
        }
    }
}
