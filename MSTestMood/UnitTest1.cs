﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestMood
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Sadmood_Expecting_Sad_Results()
        {
            MoodAnalyzer mood = new MoodAnalyzer("I am in sad mood");
            string expected = "sad";

            //Act
            string actual = mood.Analyser();

            //Asert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
