using System;

namespace ProjectAanagramCheck
{
    public class Anagram
    {
        private string SortString(string cadena)
        {
            char[] cadenaArr = cadena.ToCharArray();
            Array.Sort(cadenaArr);

            return new string(cadenaArr);

        }
        public bool AreAnagrams(string s1, string s2)
        {
            if (s1 == null || s2 == null)
            {
                throw new ArgumentNullException();
            }

            string s1Sorted = SortString(s1);
            string s2Sorted = SortString(s2);

            if (s1Sorted.Equals(s2Sorted))
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}
