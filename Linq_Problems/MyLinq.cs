using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    public static class MyLinq
    {
        // Seperated into two methods, just to show my work and reasoning.

        /// <summary>
        /// First Converts to lowercase, then checks for "th".
        /// </summary>
        /// <param name="words">List of strings to parse.</param>
        /// <returns>List of strings containing 'th'</returns>
        public static List<string> WordsWithTh(List<string> words)
        {
            return words.Where(w => w.ToLower().Contains("th")).ToList();
        }
        public static List<string> NoDuplicates(List<string> words)
        {
            return words.Distinct().ToList();
        }
        public static double ClassAverageWithoutLowestGrade(List<string> classGrades)
        {
            var substringsInts = classGrades
                                        .Select(w => w.Split(',').Select(s => Convert.ToDouble(s))
                                        .OrderByDescending(s => s)
                                        )
                                          .Select(s => s.Take(s.Count()-1))
                                          .Select(r=>r.Average())
                                          .Average()
                                      ;
            return substringsInts;
        }
        public static string AlphabeticalFrequency(string word)
        {
            return new string(word
                                .Select(c => Char.ToUpper(c)) //make all capital
                                .OrderBy(c => c) // alphabetical
                                .GroupBy(c => c) //Group by letter
                                .ToDictionary(d => d.Key, d => d.Count())  // ToDict won't try to put letter in a key twice, yeah!
                                .Select(x => $"{x.Key}{x.Value}")  // Select a string based on key=letteruppercase,value=count of letter
                                .SelectMany(pair => pair.ToCharArray())  //  Trouble making it to string, so change to char array
                                .ToArray<char>()); // change IEnumerable<char> to a regular char array, still can't convert, but string 
                                                   //constructor will take them all and make a string. Closest I could get with only
                                                   // one statement.
        }







        /*------------------------------------------------------------------------------------------------------------------------
         * 
         * 
         * 
         * -----------------------------------------------------------------------------------------------------------------------
         */

















        /// <summary>
        /// Assumes we are only taking in lowercase words.
        /// </summary>
        /// <param name="words">List of strings to parse.</param>
        /// <returns>List of strings containing 'th'</returns>
        public static List<string> WordsWithThNoCheck(List<string> words)
        {
            // Using var:
            //var wordsWithTH = words.Where(w => w.Contains("th")).Select(w => w).ToList();

            return words.Where(w => w.Contains("th")).Select(w => w).ToList();
        }

        public static double ClassAverageWithoutLowestGradeMulti(List<string> classGrades)
        {

            var substringsInts = classGrades.Select(w => w.Split(',').Select(s => Convert.ToInt32(s)));
            var removeMin = substringsInts.Select(s => s.Where(x => x > s.Min()));
            var individualAvg = removeMin.Select(r => r.Average());

            return individualAvg.Average();
        }
        // Does not work if two grades equal the lowest grade.
        public static double ClassAverageWithoutLowestGradeChain(List<string> classGrades)
        {

            var substringsInts = classGrades
                                            .Select(
                                                    w => w.Split(',')
                                                                    .Select(s => Convert.ToInt32(s))
                                                    )
                                                    .Select(s => s
                                                                  .Where(x => x > s.Min()))
                                                    .Select(r => r.Average())
                                                    .Average();
            return substringsInts;
        }

   
        //public static string AlphabeticalFrequency(string word)
        //{
        //    int position = 0;
        //    var splitLetters = word.Select(l => Char.ToUpper(l)).OrderBy(w => w).ToList();

        //    var result = word.GroupBy(c => char.ToUpper(c)).ToDictionary(gr => gr.Key, gr => gr.Count()).Select(x => $"{x.Key}{x.Value}");
            
        //    //var letterCount = word.Count(l => )

        //    var matchingLetters =
                


        //    throw new NotImplementedException();
        //}


    }
}
