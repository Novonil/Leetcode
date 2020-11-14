using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class SortArrayByParity
	{
		public int[] SortArrayByParitys(int[] A)
		{
			int[] arr = new int[A.Length];
			int idx = 0;
			for(int i = 0; i<A.Length; i++)
			{
				if(A[i] %2 == 0)
				{
					arr[idx++] = A[i];
				}
			}
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] % 2 != 0)
				{
					arr[idx++] = A[i];
				}
			}
			return arr;
		}
	}
}
