// <copyright file="Student.cs" company="OO">
// Copyright (c) OO. All rights reserved.
// </copyright>

namespace Day12_Inheritance
{
    /// <summary>
    /// Class <c>Student</c> models a student.
    /// </summary>
    public class Student : Person
    {
        private readonly int[] testScores;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">First Name of a student.</param>
        /// <param name="lastName">Lirst Name of a student.</param>
        /// <param name="id">Id of a student.</param>
        /// <param name="scores">Scores of a student.</param>
        public Student(string firstName, string lastName, int id, int[] scores)
            : base(firstName, lastName, id)
        {
            this.testScores = scores;
        }

        /// <summary>
        /// Calculates the letter representation of the average of score values.
        /// </summary>
        /// <returns>A character representating the average.</returns>
        public char Calculate()
        {
            int average = this.GetScoresAverage();

            if (average >= 90 && average <= 100)
            {
                return 'O';
            }
            else if (average >= 80 && average < 90)
            {
                return 'E';
            }
            else if (average >= 70 && average < 80)
            {
                return 'A';
            }
            else if (average >= 55 && average < 70)
            {
                return 'P';
            }
            else if (average >= 40 && average < 55)
            {
                return 'D';
            }
            else
            {
                return 'T';
            }
        }

        private int GetScoresAverage()
        {
            int total = 0;

            foreach (int score in this.testScores)
            {
                total += score;
            }

            int average = total / this.testScores.Length;

            return average;
        }
    }
}
