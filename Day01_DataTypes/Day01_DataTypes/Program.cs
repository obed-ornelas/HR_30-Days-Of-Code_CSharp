using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  OO 06-03-2020

  Task
  ----------------------------------------------------------------------------------------------------------
  Complete the code in the editor below. The variables 'i', 'd', and 's' are already declared and
  initialized for you. You must:

    1. Declare 3 variables: one of type int, one of type double, and one of type String.
    2. Read 3 lines of input from stdin (according to the sequence given in the Input Format section below)
       and initialize your 3 variables.
    3. Use the + operator to perform the following operations:
        1. Print the sum of 'i' plus your int variable on a new line.
        2. Print the sum of 'd' plus your double variable to a scale of one decimal place on a new line.
        3. Concatenate 's' with the string you read as input and print the result on a new line.

  Input Format
  ----------------------------------------------------------------------------------------------------------
  The first line contains an integer that you must sum with 'i'.
  The second line contains a double that you must sum with 'd'.
  The third line contains a string that you must concatenate with 's'.

  Sample Input
  ----------------------------------------------------------------------------------------------------------
  12
  4.0
  is the best place to learn and practice coding!

  Sample Output
  ----------------------------------------------------------------------------------------------------------
  16
  8.0
  HackerRank is the best place to learn and practice coding!

*/

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
