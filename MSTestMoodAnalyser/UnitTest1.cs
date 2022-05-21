using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        private readonly object excepted;

        /// <summary>
        /// TC1.1:Given Iam in sad mood should Return sad.
        /// </summary>
        [TestMethod]
        public void Given_Sadmood_Should_Return_Sad(object Asert)
        {
            //Arrange;
            MoodAnalyser mood = new MoodAnalyser("I am in sad mood");
            string expected = "sad";
            //Act
            string actual = mood.Analyser();
            //Asert
            object p = Asert.AreEqual(excepted, actual);
        }
        public void Given_Sadmood_Should_Return_Happy(object Asert)
        {
            //Arrange;
            MoodAnalyser mood = new MoodAnalyser("I am in Happy mood");
            string expected = "sad";
            //Act
            string actual = mood.Analyser();
            //Asert
            object p = Asert.AreEqual(excepted, actual);
        }
    }

 
}
