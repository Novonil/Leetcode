using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class FindMinimumInRotatedSortedArrayI
	{
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            return findInflectionPoint(nums, 0, nums.Length - 1);
        }

        public int findInflectionPoint(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] < nums[end])
                    end = mid;

                else if (nums[mid] > nums[end])
                    start = mid + 1;

                else
                    end -= 1;
            }

            return nums[start];
        }
    }
}
