using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class SearchInARotatedSortedArray
	{
		public static int Search(int[] nums, int target)
		{
			if(nums.Length == 1)
			{
				if (nums[0] == target)
					return 0;
				else
					return -1;
			}
			if (nums.Length == 2)
			{
				int res = nums[0] == target ? 0 : nums[1] == target ? 1 : -1;
				return res;
			}
			int index = IndexOfPivotOfSortedArray(nums);
			if(index != -1)
			{
				int resLeft = BinarySearch(nums, target, 0, index - 1);
				int resRight = BinarySearch(nums, target, index, nums.Length - 1);
				if (resLeft != -1)
					return resLeft;
				else if (resRight != -1)
					return resRight;
				return -1;
			}
			else
			{
				return BinarySearch(nums, target, 0, nums.Length - 1);
			}
			
		}
		public static int IndexOfPivotOfSortedArray(int[] nums)
		{
			int n = nums.Length;
			int start = 0;
			int end = nums.Length - 1;
			
			while(start <= end)
			{
				int mid = start + ((end - start) / 2);
				int prev = (mid + n - 1) % n;
				int next = (mid + 1) % n;

				if(nums[mid] < nums[prev] && nums[mid] < nums[next])
				{
					return mid;
				}
				if(nums[0] < nums[mid])
				{
					start = mid + 1;
				}
				if(nums[mid] < nums[n-1])
				{
					end = mid - 1;
				}
			}
			return -1;
		}
		public static int BinarySearch(int[] nums, int target, int start, int end)
		{
			while(start <= end)
			{
				int mid = start + ((end - start) / 2);
				if(nums[mid] == target)
				{
					return mid;
				}
				else if(target < nums[mid])
				{
					end = mid - 1;
				}
				else
				{
					start = mid + 1;
				}
			}
			return -1;
		}
	}
}
