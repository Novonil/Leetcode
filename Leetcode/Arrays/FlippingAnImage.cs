using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class FlippingAnImage
	{
		public int[][] FlipAndInvertImage(int[][] A)
		{
			int temp;
			for(int i = 0; i<A.Length; i++)
			{
				for(int j = 0; j< A[0].Length/2; j++)
				{
					temp = A[i][j];
					A[i][j] = A[i][A[0].Length - 1 - j];
					A[i][A[0].Length - 1 - j] = temp;
				}
				for(int j = 0; j< A[0].Length; j++)
				{
					if (A[i][j] == 0)
						A[i][j] = 1;
					else
						A[i][j] = 0;
				}
			}
			return A;
		}
	}
}
