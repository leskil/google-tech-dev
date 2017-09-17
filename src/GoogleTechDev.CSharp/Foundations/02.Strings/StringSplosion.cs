﻿using NUnit.Framework;

namespace GoogleTechDev.CSharp.Foundations._02.Strings
{
    /// <summary>
    /// Given a non-empty string like "Code" return a string like "CCoCodCode".
    /// </summary>
    /// <remarks>
    /// https://techdevguide.withgoogle.com/paths/foundational/stringsplosion-problem-ccocodcode
    /// </remarks>
    [TestFixture]
    public class StringSplosion : TestClass
    {
        [Test]
        [TestCase("ab", "aab")]
        [TestCase("abc", "aababc")]
        [TestCase("Code", "CCoCodCode")]
        public void ForLoop(string input, string expectedResult)
        {
            var result = string.Empty;

            for (var i = 0; i < input.Length; i++)
            {
                result = result + input.Substring(0, i + 1);
            }

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}