using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class MinimumWindowSubsequence
	{
		public static string MinWindow(string S, string T)
		{
			int size = S.Length;
			int left = 0;
			int right = 0;
			Dictionary<char, int> charMap = calculateFrequency(T);
			int countOfNonMatches = charMap.Count;
			int minSubstring = int.MaxValue;
			int resultLeft = -1;
			int resultRight = -1;

			while(right < size)
			{
				if(charMap.ContainsKey(S[right]))
				{
					charMap[S[right]]--;
					if(charMap[S[right]] == 0)
					{
						countOfNonMatches--;
					}
				}

				if (countOfNonMatches == 0)
				{
					while(countOfNonMatches == 0)
					{
						if(minSubstring > right - left + 1)
						{
							minSubstring = right - left + 1;
							resultLeft = left;
							resultRight = right;
						}
						
						if (charMap.ContainsKey(S[left]))
						{
							charMap[S[left]]++;
							if(charMap[S[left]] == 1)
							{
								countOfNonMatches++;
							}
						}
						left++;
					}
				}
				right++;
			}
			return resultLeft == -1 ? null : S.Substring(resultLeft, (resultRight - resultLeft + 1));
		}

		public static Dictionary<char,int> calculateFrequency(string s)
		{
			Dictionary<char, int> charMap = new Dictionary<char, int>(); 

			foreach(char c in s)
			{
				if (charMap.ContainsKey(c))
				{
					charMap[c]++;
				}
				else
				{
					charMap.Add(c,1);
				}	
			}
			return charMap;
		}
	}
}
