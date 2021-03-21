using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class LongestSubstringWithAtMostTwoDistinctCharactes
	{
		public static int LengthOfLongestSubstringTwoDistinct(string s)
		{
			if(s == null && s.Length == 0)
			{
				return 0;
			}
			int size = s.Length;
			int left = 0;
			int right = 0;
			int maxSubstring = int.MinValue;
			Dictionary<char, int> charMap = new Dictionary<char, int>();


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
				if(charMap.Count <= 2)
				{
					maxSubstring = Math.Max(maxSubstring, right - left + 1);
				}
				else if(charMap.Count > 2)
				{
					while(charMap.Count > 2)
					{
						if(charMap.ContainsKey(s[left]))
						{
							charMap[s[left]]--;
							if(charMap[s[left]] == 0)
							{
								charMap.Remove(s[left]);
							}
						}
						left++;
					}
					if(charMap.Count == 2)
					{
						maxSubstring = Math.Max(maxSubstring, right - left + 1);
					}
				}
				right++;
			}
			return maxSubstring;
		}
	}
}
