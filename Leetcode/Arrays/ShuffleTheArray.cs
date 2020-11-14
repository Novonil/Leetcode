using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class ShuffleTheArray
	{
		public int[] Shuffle(int[] nums, int n)
		{
			int[] result = new int[nums.Length];
			int x = 0, y = n, index = 0;

			while(x < n || y < 2*n)
			{
				if (index % 2 == 0)
					result[index++] = nums[x++];
				else
					result[index++] = nums[y++];
			}
			return result;
		}
	}
}
