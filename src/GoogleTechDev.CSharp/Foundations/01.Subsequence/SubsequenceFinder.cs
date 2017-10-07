using NUnit.Framework;

namespace GoogleTechDev.CSharp.Foundations._01.Subsequence
{
    /// <summary>
    /// Find the longest subsequence of a string in a set of strings.
    /// </summary>
    /// <remarks>
    /// https://techdevguide.withgoogle.com/paths/foundational/find-longest-word-in-dictionary-that-subsequence-of-given-string
    /// </remarks>
    [TestFixture]
    public class SubsequenceFinder : TestClass
    {
        [Test]
        public void Greedy()
        {
            const string s = "abppplee";
            var d = new[] {"able", "ale", "apple", "bale", "kangaroo"};
            var result = string.Empty;

            foreach (var candidate in d)
            {
                var sIndex = 0;
                var isSubsequence = false;

                // 1. Go through each char in candidate
                for (var i = 0; i < candidate.Length; i++)
                {
                    // 2. Go through each char in s, starting from where we found the last match, + 1
                    for (var j = sIndex; j < s.Length; j++)
                    {
                        // 3. Match! 
                        if (s[j] == candidate[i])
                        {
                            // 4. Mark the position so we can start from there
                            sIndex = j;

                            // 5. If we are at the last position of candidate, is a subsequence!
                            if (i == candidate.Length - 1)
                                isSubsequence = true;
                            break;
                        }
                    }
                }

                if (isSubsequence && candidate.Length > result.Length)
                    result = candidate;
            }

            Assert.That(result, Is.EqualTo("apple"));
        }        
    }
}