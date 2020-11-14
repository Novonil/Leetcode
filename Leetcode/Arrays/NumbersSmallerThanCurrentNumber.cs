using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class NumbersSmallerThanCurrentNumber
	{
		public int[] SmallerNumbersThanCurrentSquared(int[] nums)
		{
			int[] result = new int[nums.Length];
			int count = 0;
			for(int i = 0; i<nums.Length; i++)
			{
				for(int j=0; j<nums.Length; j++)
				{
					if (nums[i] > nums[j])
						count++;
				}
				result[i] = count;
				count = 0;
			}

			return result;
		}

		public int[] SmallerNumbersThanCurrent(int[] nums)
		{
			int max = nums[0];
			for(int i = 1; i< nums.Length; i++)
			{
				if (nums[i] > max)
					max = nums[i];
			}

			int[] count = new int[max + 1];

			for(int i = 0; i<nums.Length; i++)
			{
				count[nums[i]]++;
			}	

			for(int i = 1; i < count.Length; i++)
			{
				count[i] += count[i - 1];
			}
			int[] result = new int[nums.Length];
			for(int i = 0; i<nums.Length; i++)
			{
				if (nums[i] == 0)
					result[i] = 0;
				else
				{
					result[i] = count[nums[i] - 1];
				}
			}

			return result;
		}


	}
}