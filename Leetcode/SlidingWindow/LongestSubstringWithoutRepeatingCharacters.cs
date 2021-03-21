using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class LongestSubstringWithoutRepeatingCharacters
	{
		public static int LengthOfLongestSubstring(string s)
		{
			if (s == null || s.Length == 0)
			{
				return 0;
			}

			int left = 0;
			int right = 0;
			int size = s.Length;
			int maxSubstring = int.MinValue;

			Dictionary<char, int> charMap = new Dictionary<char, int>();


			while (right < size)
			{
				int K = right - left + 1;
				if (charMap.ContainsKey(s[right]))
				{
					charMap[s[right]]++;
				}
				else
				{
					charMap.Add(s[right], 1);
				}

				if (charMap.Count == K)
				{
					maxSubstring = Math.Max(maxSubstring, K);
				}
				else if (charMap.Count < K)
				{
					while (charMap.Count < K)
					{
						if (charMap.ContainsKey(s[left]))
						{
							charMap[s[left]]--;
							if (charMap[s[left]] == 0)
							{
								charMap.Remove(s[left]);
							}
						}
						if (charMap.Count == K)
						{
							maxSubstring = Math.Max(maxSubstring, K);
						}
						K--;
						left++;
					}
				}
				right++;
			}
			return maxSubstring;
		}
		public static int LengthOfLongestSubstringBruteForce(string s)
		{
			if(s == null || s.Length == 0)
			{
				return 0;
			}

			int size = s.Length;
			int longestSubstring = int.MinValue;
			
			for(int windowSize = 1; windowSize <= size; windowSize++)
			{
				for(int left = 0; left < size - windowSize + 1; left++)
				{
					Dictionary<char, int> charMap = new Dictionary<char, int>();
					for (int right = left; right < left+windowSize; right++)
					{
						if(charMap.ContainsKey(s[right]))
						{
							charMap[s[right]]++;
						}
						else
						{
							charMap.Add(s[right], 1);
						}
					}
					if(charMap.Count == windowSize)
					{
						longestSubstring = Math.Max(longestSubstring, windowSize);
						break;
					}
				}
			}
			return longestSubstring;
		}
	}
}
