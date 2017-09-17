using System.Linq;
using NUnit.Framework;

namespace GoogleTechDev.CSharp.Foundations._02.Strings
{
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

            for (var i =0; i < input.Length; i++)
            {
                result = result + input.Substring(0, i + 1);
            }

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}