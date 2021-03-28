using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class MinimumNumberOfKConsecutiveBitFlips
	{
		public static int MinKBitFlips(int[] A, int K)
		{
			int size = A.Length;
			int countOfFlips = 0;
			int result = 0;
			bool[] checkFlip = new bool[A.Length];

			for(int i = 0; i< size; i++)
			{
				if ((A[i] == 0 && countOfFlips % 2 == 0) || (A[i] == 1 && countOfFlips % 2 != 0))
				{
					countOfFlips++;
					result++;
					if (i + K - 1 >= size)
						return -1;

					checkFlip[i + K - 1] = true;
				}

				if(checkFlip[i])
				{
					countOfFlips--;
				}
			}
			return result;
		}
	}
}
