using System;

namespace ProjectAanagramCheck
{
    public class Anagram
    {
        public bool AreAnagrams(string s1, string s2)
        {
            if (s1 == null || s2 == null)
            {
                throw new ArgumentNullException();
            }

            return true;
        }
    }
}
