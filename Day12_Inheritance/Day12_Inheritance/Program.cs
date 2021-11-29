// <copyright file="Program.cs" company="OO">
// Copyright (c) OO. All rights reserved.
// </copyright>

using System;

namespace Day12_Inheritance
{
    /// <summary>
    /// Console Program Runner class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main entry method.
        /// </summary>
        /// <param name="args">arguments passed.</param>
        public static void Main(string[] args)
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Book Author: ");
            string author = Console.ReadLine();

            Console.Write("Enter Book Price: ");
            int price = int.Parse(Console.ReadLine());

            Book newNovel = new MyBook(title, author, price);

            newNovel.Display();
        }
    }
}
