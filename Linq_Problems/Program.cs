using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Words with 'th'
            List<string> findThWords = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            foreach (string word in MyLinq.WordsWithTh(findThWords))
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\n-------------------------------------------\n");

            // List with no duplicates
            List<string> duplicates = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            foreach (string word in MyLinq.NoDuplicates(duplicates))
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\n-------------------------------------------\n");

            // Get the average test grade of class after droping the lowest test grade of each student.
            List<string> classGrades = new List<string>()
                                                        {
                                                        "80,100,92,89,65",
                                                        "93,81,78,84,69",
                                                        "73,88,83,99,64",
                                                        "98,100,66,74,55"
                                                        };
            Console.WriteLine(MyLinq.ClassAverageWithoutLowestGrade(classGrades));

            Console.WriteLine("\n-------------------------------------------\n");

            // Return a a word in alphabetical order by letter with it's frequency printed next to it.
            string name = "Terrill";

            Console.WriteLine(MyLinq.AlphabeticalFrequency(name));



            Console.ReadLine();
        }
    }
}
