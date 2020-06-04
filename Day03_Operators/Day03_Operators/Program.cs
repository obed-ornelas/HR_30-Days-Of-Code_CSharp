using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  OO 06-03-2020

  Task
  ----------------------------------------------------------------------------------------------------------
  Given the meal price (base cost of a meal), tip percent (the percentage of the meal price being added as tip),
  and tax percent (the percentage of the meal price being added as tax) for a meal, find and print the meal's
  total cost.

  Input Format
  ----------------------------------------------------------------------------------------------------------
  There are 3 lines of numeric input:

  The first line has a double, mealCost (the cost of the meal before tax and tip).
  The second line has an integer, tipPercent (the percentage of mealCost being added as tip).
  The third line has an integer, taxPercent (the percentage of mealCost being added as tax).

  Sample Input
  ----------------------------------------------------------------------------------------------------------
  12.00
  20
  8

  Sample Output
  ----------------------------------------------------------------------------------------------------------
  15

*/

namespace Day03_Operators
{
    class Program
    {
        static int CalculateTotalCost(double mealCost, int tipPercent, int taxPercent)
        {
            double tip = mealCost * ((double)tipPercent / 100);
            double tax = mealCost * ((double)taxPercent / 100);
            int totalCost = (int)Math.Round(mealCost + tip + tax);

            return totalCost;
        }

        static void Main(string[] args)
        {
            double mealCost = Convert.ToDouble(Console.ReadLine());
            int tipPercent = Convert.ToInt32(Console.ReadLine());
            int taxPercent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CalculateTotalCost(mealCost, tipPercent, taxPercent));
        }
    }
}
