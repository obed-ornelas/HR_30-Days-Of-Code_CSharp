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
        private string title;

        /// <summary>
        /// Author of book.
        /// </summary>
        private string author;

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
        /// Gets or Sets the Title of the Book.
        /// </summary>
        public string Title
        {
            get => this.title;
            set => this.title = value;
        }

        /// <summary>
        /// Gets or Sets the Author of the Book.
        /// </summary>
        public string Author
        {
            get => this.author;
            set => this.author = value;
        }

        /// <summary>
        /// Prints all of the Book's properties.
        /// </summary>
        public abstract void Display();
    }
}
