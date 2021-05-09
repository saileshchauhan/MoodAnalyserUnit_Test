using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser;

namespace MoodAnalyserUnit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Analyse_Mood_Sad()
        {
            var message = new Program("I am in sad mood");
            string expected = message.Analyse_Mood();
            Assert.AreEqual("SAD", expected);
        }
        [TestMethod]
        public void Test_Analyse_Mood_Any()
        {
            var message = new Program(" ");
            string expected = message.Analyse_Mood();
            Assert.AreEqual("HAPPY", expected);
        }
    }
}
