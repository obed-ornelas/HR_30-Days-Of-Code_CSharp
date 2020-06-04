using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Operators
{
    class Program
    {
        static int calculateTotalCost(double mealCost, int tipPercent, int taxPercent)
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

            Console.WriteLine(calculateTotalCost(mealCost, tipPercent, taxPercent));
        }
    }
}
