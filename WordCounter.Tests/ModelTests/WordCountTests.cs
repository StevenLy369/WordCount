using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount.Models;

namespace WordCount.TestTools
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]

        public void GetCount_WordCount_Count1()
        {
            WordCounter newWordCount = new WordCounter("cat", "cat");
            int count = newWordCount.GetCount();
            Assert.AreEqual(1, count);
        }

        [TestMethod]

        public void WordCount_GetCount_Count1()
        {
            WordCounter newWordCount = new WordCounter("charlie", "charlie charlie ! wow heya wow thats so cool bro");
            int count = newWordCount.GetCount();
            Assert.AreEqual(2, count);
        }

        [TestMethod]

        public void WordCount_SentenceToLower_Count1()
        {
            WordCounter newWordCount = new WordCounter("charlie", "Charlie");
            int count = newWordCount.GetCount();
            Assert.AreEqual(1, count);
        }
        [TestMethod]
        public void WordCount_InputToLower_Count1()
        {
            WordCounter newWordCount = new WordCounter("ChArlIE", "charlie");
            int count = newWordCount.GetCount();
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void WordCount_NoMatch_Count0()
        {
            WordCounter newWordCount = new WordCounter("wow", "pow");
            int count = newWordCount.GetCount();
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void WordCount_NoMatch_Count3()
        {
            WordCounter newWordCount = new WordCounter("wow", "wow ! @ # $ % #$# wow wow pow fsdfsdf xcvnxm ewrew sf sd 8297349");
            int count = newWordCount.GetCount();
            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void WordCount_RemovePunctuation_Count1()
        {
            WordCounter newWordCount = new WordCounter("wow", "wow!");
            int count = newWordCount.GetCount();
            Assert.AreEqual(1, count);
        }
    }
}