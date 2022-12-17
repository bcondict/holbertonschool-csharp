using System;
using System.Collections.Generic;

namespace Text
{
	/// <summary>have multiple methods for manage strings</summary>
    public class Str
    {
		/// <summary>Check the number of words in the string.</summary>
		/// <returns>The number of words in the string.</returns>
		public static int CamelCase(string s)
		{
			if (s == null || s.Length == 0)
				return 0;

			List<string> words = new List<string>();
			string word = "";

			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] >= 'A' && s[i] <= 'Z')
				{
					words.Add(word);
					word = "" + s[i];
				}
				else
					word += s[i];
			}
			words.Add(word);
			return words.Count;
		}
    }
}
