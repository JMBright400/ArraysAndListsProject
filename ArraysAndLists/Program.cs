using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] numbersArray = new int[] {1,2,3,4,5,6,7,8,9,10};
            for (int i = 0; i < 10; i++) 
            {
                numbersArray[i] = i + 3;
            }

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            

            foreach (int number in numbersArray) 
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }

            Console.WriteLine("Even numbers:");
            foreach (int even  in evens)
            {
                Console.WriteLine($"Even: {evens}");
            }

            Console.WriteLine("Odd numbers:");
            foreach (int odd in odds)
            {
                Console.WriteLine($"Odd: {odd}");
            }

        }
    }
}
