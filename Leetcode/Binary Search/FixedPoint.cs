using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class FixedPoint
	{
		public static int FixedPointBruteForce(int[] A)
		{
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] == i)
					return i;
			}
			return -1;
		}
		public static int FixedPoints(int[] A)
		{
			int start = 0;
			int end = A.Length - 1;
			int mid;
			int result = -1;

			while(start <= end)
			{
				mid = start + ((end - start) / 2);

				if(A[mid] >= mid)
				{
					if(A[mid] == mid)
					{
						result = mid;
					}
					end = mid - 1;
				}
				else
				{
					start = mid + 1;
				}
			}
			return result;
		}
	}
}
