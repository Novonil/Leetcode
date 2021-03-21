using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class LongestStringWithAtmostKDistinctCharacters
	{
		public static int LengthOfLongestSubstringKDistinct(string s, int k)
		{
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

				if(charMap.Count <= k)
				{
					maxSubstring = Math.Max(maxSubstring, right - left + 1);
				}
				else
				{
					while(charMap.Count > k)
					{
						if (charMap.ContainsKey(s[left]))
						{
							charMap[s[left]]--;
							if(charMap[s[left]] == 0)
							{
								charMap.Remove(s[left]);
							}
						}
						left++;
					}
					if(charMap.Count <= k)
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
