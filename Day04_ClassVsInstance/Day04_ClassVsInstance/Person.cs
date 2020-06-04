﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_ClassVsInstance
{
    class Person
    {
        public int age;

        public Person(int age)
        {
            if(age < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");

                this.age = 0;
            }

            this.age = age;

        }

        public void amIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            age++;
        }
    }
}
