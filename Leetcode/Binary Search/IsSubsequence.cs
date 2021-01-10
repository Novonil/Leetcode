using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class IsSubsequence
	{
		public static bool IsSubsequenceBF(string s, string t)
		{
			int slen = s.Length;
			int tlen = t.Length;
			int i = 0;
			int j = 0;
			bool letterMatched = false;

			while (i < slen)
			{
				letterMatched = false;
				while (j < tlen)
				{
					if (s[i] == t[j])
					{
						letterMatched = true;
						j++;
						break;
					}
					j++;
				}
				if (!letterMatched)
					return false;
				i++;
			}
			return true;
		}
		public bool IsSubsequenceLinearSearch(string s, string t)
		{
			Dictionary<int, List<int>> charIndexMap = new Dictionary<int, List<int>>();

			for (int i = 0; i < t.Length; i++)
			{
				if (!charIndexMap.ContainsKey(t[i]))
				{
					List<int> l = new List<int>();
					l.Add(i);
					charIndexMap.Add(t[i], l);
				}
				else
				{
					charIndexMap[t[i]].Add(i);
				}
			}

			int lastCharIndex = -1;

			for (int i = 0; i < s.Length; i++)
			{
				if (!charIndexMap.ContainsKey(s[i]))
					return false;

				bool isMatched = false;

				foreach (int j in charIndexMap[s[i]])
				{
					if (lastCharIndex < j)
					{
						isMatched = true;
						lastCharIndex = j;
						break;
					}

				}
				if (!isMatched)
					return false;
			}
			return true;
		}
		public static bool IsSubsequenceBinarySearch(string s, string t)
		{
			Dictionary<int, List<int>> charIndexMap = new Dictionary<int, List<int>>();

			for (int i = 0; i < t.Length; i++)
			{
				if (!charIndexMap.ContainsKey(t[i]))
				{
					List<int> l = new List<int>();
					l.Add(i);
					charIndexMap.Add(t[i], l);
				}
				else
				{
					charIndexMap[t[i]].Add(i);
				}
			}

			int lastCharIndex = -1;

			for (int i = 0; i < s.Length; i++)
			{
				if (!charIndexMap.ContainsKey(s[i]))
					return false;

				bool isMatched = false;
				int start = 0;
				int end = charIndexMap[s[i]].Count - 1;
				int mid;

				while (start <= end)
				{
					mid = start + (end - start) / 2;

					if (charIndexMap[s[i]][mid] <= lastCharIndex)
					{
						start = mid + 1;
					}
					else
					{
						end = mid - 1;
					}
				}
				if (start != charIndexMap[s[i]].Count)
				{
					lastCharIndex = charIndexMap[s[i]][start];
				}
				else
					return false;
			}
			return true;
		}
		public static bool IsSubsequenceDynamicProgramming(string s, string t)
		{
			int[,] dp = new int[s.Length + 1,t.Length + 1];

			for(int i = 1; i <= s.Length; i++)
			{
				for(int j = 1; j <= t.Length; j++)
				{
					if(s[i-1] == t[j-1])
					{
						dp[i,j] = dp[i - 1,j - 1] + 1;
					}
					else
					{
						dp[i, j] = Math.Max(dp[i - 1, j],dp[i,j-1]);
					}
				}
			}

			return (dp[s.Length, t.Length] == s.Length);
		}
	}
}
