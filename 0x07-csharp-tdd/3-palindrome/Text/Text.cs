using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <sumary> Contains multiple method to evalluate string.</sumary>
    public class Str
    {

        /// <sumary> Cleans a string by removing special characters </sumary>
        /// <returns> Passed string without special characters</returns>
        public static string CleanString(string s)
        {
            string result = Regex.Replace(s, @"[^A-Za-z0-9]", "");
            return result;
        }

        /// <sumary> Check if a string is palindrome</sumary>
        /// <returns> True if is palindrome, otherwise false </returns>
        public static bool IsPalindrome(string s)
        {
            string result = CleanString(s.ToLower());

            char[] CharArray = result.ToCharArray();
            Array.Reverse(CharArray);

            string reversed = new String(CharArray);

            if (result.Equals(reversed))
                return true;
            return false;
        }
    }
}
