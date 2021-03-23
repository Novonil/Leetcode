using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class LongestSubstringWithAtLeastKRepeatingCharacters
	{
		public int LongestSubstring(string s, int k)
		{
			if (k == 1)
			{
				return s.Length;
			}
			int size = s.Length;
			int left = 0;
			int right = 0;
			int countOfCharsCrossingK = 0;
			Dictionary<char, int> charMap = new Dictionary<char, int>();
			int maxSubstring = 0;

			while(right < size)
			{
				if(charMap.ContainsKey(s[right]))
				{
					charMap[s[right]]++;
				}
				else
				{
					charMap.Add(s[right], 1);
				}
				if(charMap[s[right]] == k)
				{
					countOfCharsCrossingK++;
				}

				if(countOfCharsCrossingK == charMap.Count)
				{
					maxSubstring = Math.Max(maxSubstring, right - left + 1);
				}
				else
				{

				}
				right++;
			}
			return maxSubstring;
		}
	}
}
