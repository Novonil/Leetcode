using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class BinarySearch
	{
        public static int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int mid;

            while (start <= end)
            {
                mid = start + ((end - start) / 2);

                if (nums[mid] == target)
                {
                    return mid;
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
            return -1;
        }
    }
}
