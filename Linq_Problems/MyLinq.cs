﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    public static class MyLinq
    {
        // Seperated into two methods, just to show my work and reasoning.

        /// <summary>
        /// Assumes we are only taking in lowercase words.
        /// </summary>
        /// <param name="words">List of strings to parse.</param>
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
        /// <param name="words">List of strings to parse.</param>
        /// <returns>List of strings containing 'th'</returns>
        public static List<string> WordsWithThUpperCase(List<string> words)
        {
            //var wordsWithTH = words.Where(w => w.ToLower().Contains("th")).ToList();

            return words.Where(w => w.ToLower().Contains("th")).ToList();
        }


        public static List<string> NoDuplicates(List<string> words)
        {

            //var noDuplicates = words.Distinct().ToList();

            return words.Distinct().ToList();
        }

        public static double ClassAverageWithoutLowestGrade(List<string> classGrades)
        {

            var substringsInts = classGrades.Select(w => w.Split(',').Select(s => Convert.ToInt32(s)));
            var removeMin = substringsInts.Select(s => s.Where(x => x > s.Min()));
            var individualAvg = removeMin.Select(r => r.Average());

            return individualAvg.Average();
        }

        public static string AlphabeticalFrequency(string word)
        {
            throw new NotImplementedException();
        }


    }
}
