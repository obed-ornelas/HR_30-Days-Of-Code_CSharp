using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
