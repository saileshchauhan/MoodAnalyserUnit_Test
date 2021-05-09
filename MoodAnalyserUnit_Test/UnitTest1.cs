using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser;

namespace MoodAnalyserUnit_Test
{
    [TestClass]
    public class UnitTest1
    {
        Program program = new Program();

        [TestMethod]
        public void Test_addNumber()
        {
            //Act
            //Arrange
            int result = program.addNumber(2,5);
            //Assert
            Assert.AreEqual(7, result);
        }
        [TestMethod]
        public void Test_Analyse_Mood_Sad()
        {
            string result = program.Analyse_Mood("I am in  Sad mood");
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void Test_Analyse_Mood_Any()
        {
            string result = program.Analyse_Mood("  ");
            Assert.AreEqual("HAPPY", result);
        }
    }
}
