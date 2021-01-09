using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class CheckIfANumberIsAMajorityElementInASortedArray
	{
		public static bool IsMajorityElement(int[] nums, int target)
		{
			int n = nums.Length;
			int start = 0;
			int end = n - 1;
			int mid;
			int firstOccurence = 0;
			int lastOccurence = 0;

			while (start <= end)
			{
				mid = start + ((end - start) / 2);

				if (nums[mid] == target)
				{
					firstOccurence = mid;
					end = mid - 1;
				}
				else if (nums[mid] < target)
				{
					start = mid + 1;
				}
				else
				{
					end = mid - 1;
				}
			}
			start = 0;
			end = n - 1;
			while (start <= end)
			{
				mid = start + ((end - start) / 2);

				if (nums[mid] == target)
				{
					lastOccurence = mid;
					start = mid + 1;
				}
				else if (nums[mid] < target)
				{
					start = mid + 1;
				}
				else
				{
					end = mid - 1;
				}
			}
			if (lastOccurence - firstOccurence + 1 > n / 2)
				return true;
			return false;
		}
		public static bool IsMajorityElementBinarySearch(int[] nums, int target)
		{
			int n = nums.Length;
			int start = 0;
			int end = n - 1;
			int mid;
			int firstOccurence = 0;

			while (start <= end)
			{
				mid = start + ((end - start) / 2);
				if (nums[mid] >= target)
				{
					if (nums[mid] == target)
					{
						firstOccurence = mid;
					}
					end = mid - 1;
					
				}
				else
				{
					start = mid + 1;
				}
			}

			if (nums[firstOccurence + n / 2] == target)
				return true;
			return false;
		}
	}
}
