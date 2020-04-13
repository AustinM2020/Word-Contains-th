using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            WordLibrary wordLibrary = new WordLibrary();
            List<string> words = wordLibrary.GetWords();

            var wordsWithTh = words.Where(w => w.Contains("th"));
            var actualWord = wordsWithTh.Select(w => w).ToList();
            foreach(var word in actualWord)
            {
                Console.WriteLine(word);
            }

        }
    }
}
