using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {


             /* Create an int Array and populate numbers 1-10
              * Create two Lists of type int. Name one List "evens" and other "odds"
              * Using either a foreach or for loop,
              * Check to see if a number is even or odd.
              * Then add those numbers to either the evens List or the odds List
              * Display each List of even and odd numbers
              */


            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evens = new List<int>();
            var odds = new List<int>();

            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            Console.WriteLine();
            Console.WriteLine("The list of even numbers begins here:");
            Console.WriteLine();

            foreach (var x in evens)
            {
                Console.WriteLine($"{x} is an even number");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("The list of odds numbers begins here:");
            Console.WriteLine();

            foreach (var y in odds)
            {  
                Console.WriteLine($"{y} is an odd number");
            }
        }
    }
}
