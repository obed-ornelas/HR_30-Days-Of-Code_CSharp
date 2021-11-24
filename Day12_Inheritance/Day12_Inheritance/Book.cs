// <copyright file="Book.cs" company="OO">
// Copyright (c) OO. All rights reserved.
// </copyright>

namespace Day12_Inheritance
{
    /// <summary>
    /// Class <c>Book</c> models a book.
    /// The following is the original class given by the HackerRank Challenge.
    /// </summary>
    public abstract class Book
    {
        /// <summary>
        /// Title of book.
        /// </summary>
        protected string title;

        /// <summary>
        /// Author of book.
        /// </summary>
        protected string author;

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="title">Title of Book.</param>
        /// <param name="author">Author of Book.</param>
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        /// <summary>
        /// Prints all of the Book's properties.
        /// </summary>
        public abstract void Display();
    }
}
