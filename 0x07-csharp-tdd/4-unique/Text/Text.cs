using System;
using System.Collections.Generic;
using System.Linq;

namespace Text
{
	/// <summary>Contains multiple methods for managing strings.</summary>
    public class Str
    {
		/// <summary>Finds the first unique char in the string.</summary>
		/// <returns>The first unique char index or -1 if not found.</returns>
		public static int UniqueChar(string s)
		{
			if (s == null)
				return -1;

			List<char> CharArray = s.ToList();
			List<char> Removed = new List<char>();
			char temp = '\0';

			for (int i = 0; i < s.Length; i++)
			{
				temp = s[i];
				CharArray.RemoveAt(0);

				if (!Removed.Contains(temp) && !CharArray.Contains(temp))
					return i;

				Removed.Add(temp);
			}
			return -1;
		}
    }
}
