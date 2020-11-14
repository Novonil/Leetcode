using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Leetcode.Arrays
{
	class CreateTargetArrayInGivenOrder
	{
		public int[] CreateTargetArray(int[] nums, int[] index)
		{
			int[] target = new int[nums.Length];

			for(int i = 0; i < nums.Length; i++)
			{
				for(int j = target.Length - 1; j > index[i]; j--)
				{
					target[j] = target[j-1];
				}
				target[index[i]] = nums[i];
			}
			return target;
		}
	}
}
