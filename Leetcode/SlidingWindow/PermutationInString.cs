using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class PermutationInString
	{
		public static bool CheckInclusion(string s1, string s2)
		{
			if (s1.Length > s2.Length)
				return false;
			if (s1.Equals(s2))
				return true;

			int size1 = s1.Length;
			int size2 = s2.Length;

			bool result = checkIfPermutation(s1, s2, size1, size2);

			return result;
		}

		public static bool checkIfPermutation(string str1, string str2, int sizes1, int sizes2)
		{
			int left = 0;
			int right = 0;
			Dictionary<char, int> charMap = new Dictionary<char, int>();
			int countOfNonZeroFreqChars;
			charMap = calculateFrequency(str1);
			countOfNonZeroFreqChars = charMap.Count;

			while (right < sizes2)
			{
				if (charMap.ContainsKey(str2[right]))
				{
					charMap[str2[right]]--;
					if (charMap[str2[right]] == 0)
					{
						countOfNonZeroFreqChars--;
					}
				}
				if (right - left + 1 == sizes1)
				{
					if (countOfNonZeroFreqChars == 0)
					{
						return true;
					}
					if (charMap.ContainsKey(str2[left]))
					{
						charMap[str2[left]]++;
						if (charMap[str2[left]] == 1)
						{
							countOfNonZeroFreqChars++;
						}
					}
					left++;
				}
				right++;
			}
			return false;
		}
		public static Dictionary<char, int> calculateFrequency(string s)
		{
			Dictionary<char, int> charMap = new Dictionary<char, int>();

			foreach (char c in s)
			{
				if (charMap.ContainsKey(c))
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
