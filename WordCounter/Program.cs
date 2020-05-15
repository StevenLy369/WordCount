using System;
using System.Collections.Generic;
using WordCount.Models;



namespace WordCountGame
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter a word, you would like to count");
            string input = Console.ReadLine();
            Console.WriteLine("Please enter a sentence you would like to match");
            string sentence = Console.ReadLine();

            WordCounter newWordCounter = new WordCounter(input, sentence);
            int count = newWordCounter.GetCount();
            Console.WriteLine("Your word " + input + " Has showed up " + count + " in your sentence");
            Console.WriteLine("Your sentence was: " + sentence);
        }
    }
}