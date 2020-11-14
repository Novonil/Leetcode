using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class SquaresOfSortedArray
	{
		public int[] SortedSquares(int[] A)
		{
			for(int i = 0; i<A.Length; i++)
			{
				A[i] = A[i] * A[i];
			}
			Array.Sort(A);
			return A;
		}
	}
}
