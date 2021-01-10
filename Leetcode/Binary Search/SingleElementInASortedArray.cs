using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class SingleElementInASortedArray
	{
		public static int SingleNonDuplicateBruteForce(int[] nums)
		{
			if (nums.Length == 1)
				return nums[0];

			for(int i = 0; i < nums.Length - 1; i+=2)
			{
				if (nums[i] != nums[i + 1])
					return nums[i];
			}
			return nums[nums.Length - 1];
		}
		public static int SingleNonDuplicate(int[] nums)
		{
			if (nums.Length == 1)
				return nums[0];

			int n = nums.Length;
			int start = 0;
			int end = n - 1;
			int mid;

			while(start<=end)
			{
				mid = start + (end - start) / 2;

				int prev = (mid - 1 + n) % n; 
				int next = (mid + 1) % n;
				
				if (nums[prev] != nums[mid] && nums[mid] != nums[next])
				{
					return nums[mid];
				}
				
				if(nums[prev] != nums[mid])
				{
					if (mid % 2 == 1)
					{
						end = prev;
					}
					else
					{
						start = next;
					}
				}
				else
				{
					if (mid % 2 == 1)
					{
						start = next; 
					}
					else
					{
						end = prev;
					}
				}
			}
			return -1;
		}
	}
}
