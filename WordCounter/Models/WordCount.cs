using System;
using System.Collections.Generic;

namespace WordCount.Models
{
    public class WordCounter
    {
        private string Input { get; set; }
        private string Sentence { get; set; }

        public WordCounter(string input, string sentence)
        {
            Input = input.ToLower();
            Sentence = sentence.ToLower();
        }


        public int GetCount()
        {

            string[] array = Sentence.Split(" ");
            int count = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (Input == array[i])
                {
                    count++;
                }
                else
                {
                    count +=0;
                }
            }
            return count;
        }
    }
}
