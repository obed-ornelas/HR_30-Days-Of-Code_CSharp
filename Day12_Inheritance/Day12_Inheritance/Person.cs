// <copyright file="Person.cs" company="OO">
// Copyright (c) OO. All rights reserved.
// </copyright>

using System;

namespace Day12_Inheritance
{
    /// <summary>
    /// Class <c>Person</c> models a person.
    /// </summary>
    public class Person
    {
        private string firstName;
        private string lastName;
        private int id;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="firstName">First Name of a person.</param>
        /// <param name="lastName">Lirst Name of a person.</param>
        /// <param name="id">Id of a person.</param>
        public Person(string firstName, string lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }

        /// <summary>
        /// Gets or Sets the FirstName of the Book.
        /// </summary>
        public string FirstName
        {
            get => this.firstName;
            set => this.firstName = value;
        }

        /// <summary>
        /// Gets or Sets the LastName of the Book.
        /// </summary>k
        public string LastName
        {
            get => this.lastName;
            set => this.lastName = value;
        }

        /// <summary>
        /// Gets or Sets the Id of the Person.
        /// </summary>
        public int Id
        {
            get => this.id;
            set => this.id = value;
        }

        /// <summary>
        /// Prints details provided to create instance of Person.
        /// </summary>
        public void PrintPerson()
        {
            Console.WriteLine("Name: {0}, {1}\nID: {2}", this.LastName, this.FirstName, this.Id);
        }
    }
}
