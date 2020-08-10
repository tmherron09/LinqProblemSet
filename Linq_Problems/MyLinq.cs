using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    public static class MyLinq
    {


        public static List<string> WordsWithTH(List<string> words)
        {
            var wordsWithTH = words.Where(w => w.ToLower().Contains("th")).ToList();

            return wordsWithTH;
        }


        public static List<string> NoDuplicates(List<string> words)
        {

            throw new NotImplementedException();
        }

        public static double ClassAverageWithoutLowestGrade(List<string> classGrades)
        {
            throw new NotImplementedException();
        }

        public static string AlphabeticalFrequency(string word)
        {
            throw new NotImplementedException();
        }


    }
}
