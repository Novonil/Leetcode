using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class DecompressEncodedList
	{
		public int[] DecompressRLElist(int[] nums)
		{
			List<int> res = new List<int>();
			for(int i = 0; i<nums.Length; i+=2)
			{
				int freq = nums[i];
				int number = nums[i + 1];
				for(int j = 1; j<= freq; j++)
				{
					res.Add(number);
				}
			}
			return res.ToArray();
		}
	}
}
