using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class MaxProductOfTwoElementsInAnArray
	{
		public int MaxProduct(int[] nums)
		{
			int prod = 0, maxProd = 0;
			for(int i = 0; i<nums.Length; i++)
			{
				for(int j = i+1; j< nums.Length; j++)
				{
					prod = (nums[i] - 1) * (nums[j] - 1);
					if (prod > maxProd)
						maxProd = prod;
				}
			}
			return maxProd;
		}
	}
}
