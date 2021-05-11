﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser;

namespace MoodAnalyserUnit_Test
{
    [TestClass]
    public class UnitTest1
    {
        //TC 1.1
        [TestMethod]
        public void Test_Analyse_Mood_Sad()
        {
            var message = new Program("I am in sad mood");
            string expected = message.Analyse_Mood();
            Assert.AreEqual("SAD", expected);
        }
        //TC 1.2
        [TestMethod]
        public void Test_Analyse_Mood_Any()
        {
            var message = new Program(" ");
            string expected = message.Analyse_Mood();
            Assert.AreEqual("HAPPY", expected);
        }
        [TestMethod]
        public void Given_AnyMood_ShouldReturn_HAPPY_withconstructor()
        {
            string expected = "HAPPY";
            string message = "I am in HAPPY mood";
            Program moodAnalyser = new Program(message);
            string mood = moodAnalyser.Analyse_Mood();
            Assert.AreEqual(expected, mood);
        }
        //UC 2 test cases
        [TestMethod]
        [DataRow(null)]
        public void Given_NUll_Message_ShouldReturn_HAPPY(string message)
        {
            string expected = "HAPPY";
            Program moodAnalyser = new Program(message);
            string mood = moodAnalyser.Analyse_Mood();
            Assert.AreEqual(expected, mood);
        }

    }
}
