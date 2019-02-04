using System;
using System.Collections.Generic;

namespace _30random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i = 0;
            List<int> termsList = new List<int>();
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            while (i < 5)
            {
                int first = rnd.Next(1, 10);
                termsList.Add(first);
                i++;

            }
            foreach (var item in termsList)
            {
                Console.WriteLine(item.ToString());
            }


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
