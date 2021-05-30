using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class FindFirstAndLastPositionOfElementInSortedArray
	{
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = { -1, -1 };

            if (nums == null || nums.Length == 0)
                return result;

            int start = 0;
            int end = nums.Length - 1;

            result[0] = findFirstOccurence(nums, target, start, end);
            result[1] = findLastOccurence(nums, target, start, end);

            return result;
        }

        public int findFirstOccurence(int[] nums, int target, int start, int end)
        {
            int res = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    res = mid;
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
            return res;
        }

        public int findLastOccurence(int[] nums, int target, int start, int end)
        {
            int res = -1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    res = mid;
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
            return res;
        }
    }
}
