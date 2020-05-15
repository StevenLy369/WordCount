using System;
using System.Collections.Generic;

namespace WordCount.Models
{
    public class Scrabbles
    {



        public int GetCount(string input, string sentence)
        {   

            List<string> wordList = new List<string>{};
            int count = 0;
            wordList.Add(sentence);
            foreach(string word in wordList)
            {
                if (word == "input")
                {
                    count++;
                }
            }


        return count;



            
        }
    }
}