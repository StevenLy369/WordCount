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

            List<string> wordList = new List<string> {};
            int count = 0;
            wordList.Add(Sentence);
            foreach (string word in wordList)
            {
                if (word == Input)
                {
                    count++;
                }
                else
                {
                    count += 0;
                }
            }

            return count;

        }
    }
}
