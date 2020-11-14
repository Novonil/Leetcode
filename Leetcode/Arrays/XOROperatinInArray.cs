using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class XOROperatinInArray
	{
		public int XorOperation(int n, int start)
		{
			int[] nums = new int[n];
			
			for(int i = 0; i < n; i++)
			{
				nums[i] = start + (2 * i);
			}
			int result = nums[0];
			for (int i = 1; i < n; i++)
			{
				result = result ^ nums[i];
			}
			return result;
		}
	}
}
