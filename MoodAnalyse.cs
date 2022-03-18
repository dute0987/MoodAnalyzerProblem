﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodAnalyse
{
    [TestClass]
    public class AnalyzerTest
    {
        /// <summary>
        /// TC 1.1: Given “I am in Sad Mood” message Should Return SAD.
        /// </summary>
        [TestMethod]
        public static void GivenSadMoodShouldReturnSAD()
        {
            // Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse();

            // Act
            string mood = moodAnalyse.AnalyseMood(message);

            // Assert
            Assert.AreEqual(expected, mood);
        }
        /// <summary>
        /// TC 1.2: Given “I am in Any Mood” message Should Return HAPPY
        /// </summary>
        [TestMethod]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            // Arrange
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse();

            // Act
            string mood = moodAnalyse.AnalyseMood(message);

            // Assert
            Assert.AreEqual(expected, mood);
        }
    }
}