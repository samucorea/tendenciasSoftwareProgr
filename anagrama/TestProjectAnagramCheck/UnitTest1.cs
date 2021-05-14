using NUnit.Framework;
using ProjectAanagramCheck;

namespace TestProjectAnagramCheck
{
    public class Tests
    {


        [Test]
        public void s1_is_null_throw_ArgumentNullException()
        {
            Anagram anagram = new Anagram();

            Assert.That(() => anagram.AreAnagrams(null, "hey"), Throws.ArgumentNullException);
        }
    }
}