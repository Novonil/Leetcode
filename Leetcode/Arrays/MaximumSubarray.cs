using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class MaximumSubarray
	{
        public int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int currentSum = nums[0];
            int maxSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (currentSum <= 0)
                {
                    currentSum = nums[i];
                }
                else
                {
                    currentSum += nums[i];
                }
                maxSum = Math.Max(currentSum, maxSum);
            }
            return maxSum;
        }
    }
}
