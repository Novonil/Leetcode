using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class MinimumWindowSubstring
	{
		public static string MinWindow(string s, string t)
		{
			int left = 0;
			int right = 0;
			int size = s.Length;
			int countOfNonZeroCharacters = 0;
			Dictionary<char, int> charMap = calculateFreq(t);
			countOfNonZeroCharacters = charMap.Count;

			int minWindowSubstring = int.MaxValue;
			int len = 0;
			string str = "";

			while(right < size)
			{
				if (charMap.ContainsKey(s[right]))
				{
					charMap[s[right]]--;
					if (charMap[s[right]] == 0)
					{
						countOfNonZeroCharacters--;
					}
				}
				if(countOfNonZeroCharacters == 0)
				{
					while(countOfNonZeroCharacters == 0)
					{
						if(minWindowSubstring > right - left + 1)
						{
							str = s.Substring(left, right - left + 1);
						}
						
						minWindowSubstring = Math.Min(minWindowSubstring, right - left + 1);
						if (charMap.ContainsKey(s[left]))
						{
							charMap[s[left]]++;
							if(charMap[s[left]] == 1)
							{
								countOfNonZeroCharacters++;
							}
						}
						left++;
					}
				}
				right++;
			}
			return str;
		}
		public static Dictionary<char,int> calculateFreq(string str)
		{
			Dictionary<char, int> charMap = new Dictionary<char, int>();

			foreach(char c in str)
			{
				if(charMap.ContainsKey(c))
				{
					charMap[c]++;
				}	
				else
				{
					charMap.Add(c, 1);
				}
			}
			return charMap;
		}
	}
}
