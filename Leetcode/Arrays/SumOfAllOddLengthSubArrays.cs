using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class SumOfAllOddLengthSubArrays
	{
		public int SumOddLengthSubarrays(int[] arr)
		{
			//1, 4, 2, 5, 3
			int subarraySize = 1, sum = 0, counter = 0;

			while(subarraySize <= arr.Length)
			{
				for (int i = 0; i + subarraySize <= arr.Length; i++)
				{
					counter = 0;
					while(counter < subarraySize)
					{
						sum += arr[i + counter];
						counter++;
					}
				}
				subarraySize += 2;
			}
			return sum;
		}
	}
}
