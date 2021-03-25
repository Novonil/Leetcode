using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class LongestSubstringWithAtLeastKRepeatingCharacters
	{
		public static int LongestSubstring(string s, int k)
		{
			if(k==1)
			{
				return s.Length;
			}

			int size = s.Length;
			int maxUnique = getMaxUniqueLetters(s);
			int maxSubstring = int.MinValue;

			for(int currUnique = 1; currUnique <= maxUnique; currUnique++)
			{
				int left = 0;
				int right = 0;
				int totalUnique = 0;
				int idx = 0;
				int countAtLeastK = 0;
				int[] charMap = new int[26];

				while(right < size)
				{
					if(totalUnique <= currUnique)
					{
						idx = s[right] - 'a';

						if(charMap[idx] == 0)
						{
							totalUnique++;
						}
						
						charMap[idx]++;

						if(charMap[idx] == k)
						{
							countAtLeastK++;
						}
						right++;
					}
					else
					{
						idx = s[left] - 'a';

						if(charMap[idx] == k)
						{
							countAtLeastK--;
						}
						
						charMap[idx]--;

						if(charMap[idx] == 0)
						{
							totalUnique--;
						}
						left++;
					}
					if(totalUnique == currUnique && countAtLeastK == currUnique)
					{
						maxSubstring = Math.Max(maxSubstring, right - left);
					}
				}
			}
			return maxSubstring;
		}
		public static int getMaxUniqueLetters(string s)
		{
			bool[] charMap = new bool[26];
			int maxUnique = 0;
			int idx = 0;

			foreach(char c in s)
			{
				idx = c - 'a';
				if(!charMap[idx])
				{
					maxUnique++;
					charMap[idx] = true;
				}
			}
			return maxUnique;
		}
	}
}
