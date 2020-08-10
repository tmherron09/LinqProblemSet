﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Linq_Problems;
using System.Collections.Generic;

namespace LinqUnitTests
{
    [TestClass]
    public class MyLinqUnitTests
    {
        [TestMethod]
        public void WordsWithTH_ProblemSetInput_4Words()
        {
            //  Arrange
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            List<string> expected = new List<string>() { "the", "this", "tenth", "mathematics" };
            List<string> actual;
            //  Act
            actual = MyLinq.WordsWithTH(words);

            //  Assert

            CollectionAssert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void NoDuplicates_ProblemSetInput_OneMike()
        {
            //  Arrange
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };

            List<string> expected = new List<string>() { "Mike", "Brad", "Nevin", "Zack" };
            List<string> actual;
            //  Act
            actual = MyLinq.NoDuplicates(names);

            //  Assert

            CollectionAssert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ClassAverageWithoutLowestGrade_ProblemSetInput_86Point125()
        {
            //  Arrange
            List<string> classGrades = new List<string>()
                                                        {
                                                        "80,100,92,89,65",
                                                        "93,81,78,84,69",
                                                        "73,88,83,99,64",
                                                        "98,100,66,74,55"
                                                        };


            double expected = 86.125;
            double actual;
            //  Act
            actual = MyLinq.ClassAverageWithoutLowestGrade(classGrades);

            //  Assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AlphabeticalFrequency_ProblemSetInput_E1I1L2R2T1()
        {
            //  Arrange
            string name = "Terrill";

            string expected = "E1I1L2R2T1";
            string actual;
            //  Act
            actual = MyLinq.AlphabeticalFrequency(name);

            //  Assert

            Assert.AreEqual(expected, actual);

        }
    }
}
