using System;
using System.IO;

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
