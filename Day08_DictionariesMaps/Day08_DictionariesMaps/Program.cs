using System;
using System.Collections.Generic;

/*
  OO 06-07-2020

  Task
  ----------------------------------------------------------------------------------------------------------
  Given 'N' names and phone numbers, assemble a phone book that maps friends' names to their respective
  phone numbers. You will then be given an unknown number of names to query your phone book for. For each
  'name' queried, print the associated entry from your phone book on a new line in the form 'name=phoneNumber';
  if an entry for 'name' is not found, print 'Not found' instead.

  Input Format
  ----------------------------------------------------------------------------------------------------------
  The first line contains an integer, 'n', denoting the number of entries in the phone book.
  Each of the 'n' subsequent lines describes an entry in the form of 2 space-separated values on a single
  line. The first value is a friend's name, and the second value is an 8-digit phone number.
  After the 'n' lines of phone book entries, there are an unknown number of lines of queries. Each line
  (query) contains a 'name' to look up, and you must continue reading lines until there is no more input.

  Sample Input
  ----------------------------------------------------------------------------------------------------------
  3
  sam 99912222
  tom 11122222
  harry 12299933
  sam
  edward
  harry

  Sample Output
  ----------------------------------------------------------------------------------------------------------
  sam=99912222
  Not found
  harry=12299933

*/

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
