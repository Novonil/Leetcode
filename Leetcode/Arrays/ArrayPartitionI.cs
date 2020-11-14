using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class ArrayPartitionI
	{
		public int ArrayPairSum(int[] nums)
		{
			int sum = 0;
			Array.Sort(nums);
			for(int i = 0; i < nums.Length; i+=2)
			{
				sum += Math.Min(nums[i], nums[i + 1]);
			}
			return sum;
		}
	}
}
