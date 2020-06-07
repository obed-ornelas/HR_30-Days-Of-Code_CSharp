using System;
using System.Collections.Generic;

namespace Day08_DictionariesMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            int entries = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                string[] entry = Console.ReadLine().Split(' ');
                phoneBook.Add(entry[0], entry[1]);
            }

            string name = Console.ReadLine();

            while (!string.IsNullOrEmpty(name))
            {
                if (phoneBook.TryGetValue(name, out string phoneNumber))
                {
                    Console.WriteLine("{0}={1}", name, phoneNumber);
                }
                else
                {
                    Console.WriteLine("Not found");
                }

                name = Console.ReadLine();
            }
        }
    }
}
