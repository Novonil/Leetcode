using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class FindPeakElement
	{
		public static int FindPeakElements(int[] nums)
		{
			int n = nums.Length;
			if (nums.Length == 0)
			{
				return -1;
			}
			else if (nums.Length == 1)
			{
				return 0;
			}
			else if (nums[0] > nums[1])
			{
				return 0;
			}
			else if (nums[n - 1] > nums[n - 2])
			{
				return n - 1;
			}

			int start = 1;
			int end = n - 2;
			int mid;
			int prev;
			int next;

			while (start <= end)
			{
				mid = start + ((end - start) / 2);
				prev = mid - 1;
				next = mid + 1;

				if (nums[mid] > nums[prev] && nums[mid] > nums[next])
				{
					return mid;
				}
				else if (nums[mid] > nums[prev])
				{
					start = next;
				}
				else
				{
					end = prev;
				}
			}
			return -1;

		}
		public static int FindPeakElementsLinearScan(int[] nums)
		{
			int i = 0;
			for (i = 0; i<nums.Length - 1; i++)
			{
				if(nums[i] > nums[i+1])
				{
					break;
				}
			}
			return i;
		}
	}
}
