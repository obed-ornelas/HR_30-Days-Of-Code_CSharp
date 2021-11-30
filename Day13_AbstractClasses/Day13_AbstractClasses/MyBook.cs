// <copyright file="MyBook.cs" company="OO">
// Copyright (c) OO. All rights reserved.
// </copyright>
using System;

namespace Day13_AbstractClasses
{
    /// <summary>
    /// Class that subclasses the abstract <see cref="Book"/>
    /// which has a Price attribute.
    /// </summary>
    public class MyBook : Book
    {
        private int price;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyBook"/> class.
        /// </summary>
        /// <param name="title">Title of <see cref="MyBook"/>.</param>
        /// <param name="author">Author of <see cref="MyBook"/>.</param>
        /// <param name="price">Price of <see cref="MyBook"/>.</param>
        public MyBook(string title, string author, int price)
            : base(title, author)
        {
            this.price = price;
        }

        /// <summary>
        /// Gets or Sets the Price of the Book.
        /// </summary>
        public int Price
        {
            get => this.price;
            set => this.price = value;
        }

        /// <inheritdoc/>
        public override void Display()
        {
            Console.WriteLine("Title: {0}", this.Title);
            Console.WriteLine("Author: {0}", this.Author);
            Console.WriteLine("Price: {0}", this.Price);
        }
    }
}
