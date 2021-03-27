using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class SubarraysWithKDifferentIntegers
	{
		public static int SubarraysWithKDistinctBruteForce(int[] A, int K)
		{
			int count = 0;
			for(int left = 0; left < A.Length; left++)
			{
				int countOfUniqueNums = 0;
				HashSet<int> seen = new HashSet<int>();

				for(int right = left; right < A.Length; right++)
				{
					if(!seen.Contains(A[right]))
					{
						countOfUniqueNums++;
						seen.Add(A[right]);
					}
					if(countOfUniqueNums == K)
					{
						count++;
					}
				}
			}
			return count;
		}

		public static int SubarrayWithKDistinct(int[] A, int K)
		{
			return countWithNDistinct(A, K) - countWithNDistinct(A, K-1);
		}

		public static int countWithNDistinct(int[] A, int K)
		{
			int size = A.Length;
			int left = 0;
			int right = 0;
			Dictionary<int, int> numFreq = new Dictionary<int, int>();
			int ans = 0;

			while(right < size)
			{
				if(numFreq.ContainsKey(A[right]))
				{
					numFreq[A[right]]++;
				}
				else
				{
					numFreq.Add(A[right], 1);
				}

				if(numFreq.Count <= K)
				{
					ans += right - left + 1;
				}
				else
				{
					while(numFreq.Count > K)
					{
						if(numFreq.ContainsKey(A[left]))
						{
							numFreq[A[left]]--;
							if(numFreq[A[left]] == 0)
							{
								numFreq.Remove(A[left]);
							}
						}
						left++;
					}
					ans += right - left + 1;
				}
				right++;
			}
			return ans;
		}
	}
}
