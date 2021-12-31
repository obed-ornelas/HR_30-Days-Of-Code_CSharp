// <copyright file="Solution.cs" company="OO">
// Copyright (c) OO. All rights reserved.
// </copyright>

using System;

namespace Day12_Inheritance
{
    /// <summary>
    /// Console Solution Runner class.
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Main entry method.
        /// </summary>
        /// <param name="args">Arguments.</param>
        public static void Main()
        {
            Console.Write("Enter Student FirstName, LastName, ID (space separated): ");
            string[] inputs = Console.ReadLine().Split();

            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);

            Console.Write("Enter number of scores: ");
            int numScores = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter scores (space separated): ");
            inputs = Console.ReadLine().Split();

            int[] scores = new int[numScores];

            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Console.WriteLine();

            Student s = new Student(firstName, lastName, id, scores);
            s.PrintPerson();

            Console.WriteLine("Grade: {0}", s.Calculate());
        }
    }
}
