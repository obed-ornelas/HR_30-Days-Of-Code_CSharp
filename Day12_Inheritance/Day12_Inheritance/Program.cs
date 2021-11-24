// <copyright file="Program.cs" company="OO">
// Copyright (c) OO. All rights reserved.
// </copyright>

using System;
using System.Diagnostics.CodeAnalysis;

namespace Day12_Inheritance
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Main Entry Class")]
    public class Program
    {
        public static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());

            Book newNovel = new MyBook(title, author, price);

            newNovel.Display();
        }
    }
}
