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

        [Test]
        public void s2_is_null_throw_ArgumentNullException()
        {
            Anagram anagram = new Anagram();

            Assert.That(() => anagram.AreAnagrams("adios", null), Throws.ArgumentNullException);
        }
    }
}