using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class FindKLengthSubstringWithNoRepeatedCharacters
	{
		public static int NumKLenSubstrNoRepeats(string S, int K)
		{
			int size = S.Length;
			int left = 0;
			int right = 0;
			int result = 0;
			Dictionary<char,int> map = new Dictionary<char,int>();

			while(right < size)
			{
				if(map.ContainsKey(S[right]))
				{
					map[S[right]]++;
				}
				else
				{
					map.Add(S[right], 1);
				}
				if(right - left + 1 == K)
				{
					if(map.Count == K)
					{
						result++;
					}

					if(map.ContainsKey(S[left]))
					{
						map[S[left]]--;
						if(map[S[left]] == 0)
						{
							map.Remove(S[left]);
						}
					}
					left++;
				}
				right++;
			}
			return result;
		}
	}
}
