using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_ClassVsInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.In.ReadLine());

            for (int i = 0; i < tests; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person person = new Person(age);

                person.amIOld();

                for (int j = 0; j < 3; j++)
                {
                    person.yearPasses();
                }

                person.amIOld();

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
