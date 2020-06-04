using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int myInt;
            double myDouble;
            string myString;

            myInt = Int32.Parse(Console.ReadLine());
            myDouble = Double.Parse(Console.ReadLine());
            myString = Console.ReadLine();

            Console.WriteLine((i + myInt).ToString());
            Console.WriteLine((d + myDouble).ToString("F1"));
            Console.WriteLine(s + myString);
        }
    }
}
