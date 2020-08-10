using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    public static class MyLinq
    {


        /// <summary>
        /// Assumes we are only taking in lowercase words.
        /// </summary>
        /// <param name="words"></param>
        /// <returns>List of strings containing 'th'</returns>
        public static List<string> WordsWithTh(List<string> words)
        {
            // Using var:
            //var wordsWithTH = words.Where(w => w.Contains("th")).Select(w => w).ToList();

            return  words.Where(w => w.Contains("th")).Select(w => w).ToList();
        }
        /// <summary>
        /// First Converts to lowercase, then checks for "th".
        /// </summary>
        /// <param name="words"></param>
        /// <returns>List of strings containing 'th'</returns>
        public static List<string> WordsWithThUpperCase(List<string> words)
        {
            //var wordsWithTH = words.Where(w => w.ToLower().Contains("th")).ToList();

            return words.Where(w => w.ToLower().Contains("th")).ToList();
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
