using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class FindMinimumInRotatedSortedArray
	{
        public static int FindMin(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            return binarySearch(nums, start, end, nums.Length);
        }

        public static int binarySearch(int[] nums, int start, int end, int len)
        {
            if (start > end)
                return 10000;

            int mid = start + (end - start) / 2;
            int prev = (mid + len - 1) % len;
            int next = (mid + 1) % len;

            if (nums[mid] < nums[prev] && nums[mid] < nums[next])
                return nums[mid];

            else if (nums[mid] > nums[start])
            {
                return binarySearch(nums, mid + 1, end, len);
            }

            else if (nums[mid] < nums[end])
            {
                return binarySearch(nums, start, mid - 1, len);
            }

            else
            {
                int inflectionPoint = 10000;
                if (nums[mid] == nums[start])
                {
                    inflectionPoint = binarySearch(nums, mid + 1, end, len);
                }
                if (inflectionPoint == 10000 && nums[mid] == nums[end])
                {
                    inflectionPoint = binarySearch(nums, start, mid - 1, len);
                }
                return inflectionPoint;
            }
        }
    }
}
