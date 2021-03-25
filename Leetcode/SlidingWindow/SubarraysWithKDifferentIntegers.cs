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

		//public static int SubarrayWithKDistinct(int[] A, int K)
		//{

		//}
	}
}
