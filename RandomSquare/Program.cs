using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            var integerList = new List<int>();
            
            // FUN FACT => Computers don't truly generate random numbers.
            // Languages use pre-programmed lists of integers.
            // The 'Next' method simply generates the next integer in that list

            for (var i = 0; i < 10; i++ )
            {
                // Passing 100 to Next so that it will generate a number w/in the 0-50 range.
                integerList.Add(rdm.Next(50));
            }

            Console.WriteLine($"integer list: { String.Join(",", integerList)}");

            var squaredList = integerList.Select(integer => Math.Pow(integer, 2));

            Console.WriteLine($"squared integer list: { String.Join(",", squaredList)}");

            var evenOnlyList = squaredList.Where(num => num % 2 == 0);

            Console.WriteLine($"even integer list: { String.Join(",", evenOnlyList)}");

        }
    }
}
