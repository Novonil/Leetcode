using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class SearchInARotatedSortedArrayII
	{
        public bool Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return false;

            int start = 0;
            int end = nums.Length - 1;
            return Search(nums, target, start, end);
        }

        public bool Search(int[] nums, int target, int start, int end)
        {
            if (start > end)
                return false;

            int mid = start + (end - start) / 2;

            if (nums[mid] == target)
                return true;

            else if (nums[start] < nums[mid])
            {
                if (target >= nums[start] && target < nums[mid])
                    return Search(nums, target, start, mid - 1);
                else
                    return Search(nums, target, mid + 1, end);
            }

            else if (nums[mid] < nums[end])
            {
                if (target > nums[mid] && target <= nums[end])
                    return Search(nums, target, mid + 1, end);
                else
                    return Search(nums, target, start, mid - 1);
            }
            else
            {
                bool location = false;
                if (nums[start] == nums[mid])
                {
                    location = Search(nums, target, mid + 1, end);
                }

                if (!location && nums[mid] == nums[end])
                {
                    location = Search(nums, target, start, mid - 1);
                }

                return location;
            }
            return false;
        }
    }
}
