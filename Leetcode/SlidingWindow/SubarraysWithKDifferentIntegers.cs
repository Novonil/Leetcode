using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class SubarraysWithKDifferentIntegers
	{
		public static int SubarraysWithKDistinct(int[] A, int K)
		{
			int size = A.Length;
			int left = 0;
			int right = 0;
			Dictionary<int, int> numberMap = new Dictionary<int, int>();
			int countOfSubarrays = 0;

			while(right < size)
			{
				if(numberMap.ContainsKey(A[right]))
				{
					numberMap[A[right]]++;
				}
				else
				{
					numberMap.Add(A[right], 1);
				}

				if(numberMap.Count == K)
				{
					countOfSubarrays++;
				}
				else if (numberMap.Count > K)
				{
					while (numberMap.Count > K)
					{
						if (numberMap.ContainsKey(A[left]))
						{
							numberMap[A[left]]--;
							if (numberMap[A[left]] == 0)
							{
								numberMap.Remove(A[left]);
							}
						}
						left++;
					}
					if (numberMap.Count == K)
					{
						countOfSubarrays++;
					}
				}
				right++;
			}

			return countOfSubarrays;
		}
	}
}
