using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class Running_Sum_Of_1D_Array
	{
		public int[] RunningSum(int[] nums)
		{
			int[] result = new int[nums.Length];
			int sum = 0;

			for(int i = 0; i<nums.Length; i++)
			{
				sum = sum + nums[i];
				result[i] = sum;
			}
			return result;
		}
	}
}
