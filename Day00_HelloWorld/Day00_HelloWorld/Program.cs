using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  OO 06-03-2020

  Task
  ----------------------------------------------------------------------------------------------------------
  To complete this challenge, you must save a line of input from stdin to a variable, print 'Hello, World.'
  on a single line, and finally print the value of your variable on a second line.

  Input Format
  ----------------------------------------------------------------------------------------------------------
  A single line of text denoting 'inputString' (the variable whose contents must be printed).

  Sample Input
  ----------------------------------------------------------------------------------------------------------
  Welcome to 30 Days of Code!

  Sample Output
  ----------------------------------------------------------------------------------------------------------
  Hello, World.
  Welcome to 30 Days of Code!

*/

namespace Day00_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputString;
            inputString = Console.ReadLine();

            Console.WriteLine("Hello, World.");
            Console.WriteLine(inputString);
        }
    }
}
