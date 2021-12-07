using System;

namespace Day12_Inheritance
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person(string firstName, string lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }

        public void PrintPerson()
        {
            Console.WriteLine("Name: " + this.lastName + ", " + this.firstName + "\nID: " + this.id);
        }
    }
}
