namespace Day12_Inheritance
{
    public class Student : Person
    {
        private readonly int[] testScores;

        public Student(string firstName, string lastName, int idNumber, int[] scores)
            : base(firstName, lastName, idNumber)
        {
            this.testScores = scores;
        }

        public char Calculate()
        {
            var average = this.GetScoresAverage();

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
