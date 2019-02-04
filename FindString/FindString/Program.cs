using System;

namespace FindString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Chsarp", "Console", "Examples", "carp" };
            string longWord = "";
            int Wordcount = 0;
            foreach (string item in arr)
            {
                if (item.Length > Wordcount)
                {
                    Wordcount = item.Length;
                    longWord = item;
                }
            }

            Console.WriteLine("The longest word: {0} \nLetters count : {1}", longWord, Wordcount);
            Console.ReadKey();
        }   

    }
}
