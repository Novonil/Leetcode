using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class ShortestSubarrayWithSumAtLeastK
	{
        public static int ShortestSubarray(int[] nums, int k)
        {
            int left = 0;
            int right = 0;
            int len = nums.Length - 1;
            int minSize = int.MaxValue;
            long sum = 0;

            while (right <= len)
            {
                sum += nums[right];

                if (sum >= k)
                {
                    while (left <= right && (sum >= k || nums[left] < 0))
                    {
                        if (sum >= k)
                            minSize = Math.Min(minSize, right - left + 1);
                        sum -= nums[left];
                        left++;
                    }
                }
                right++;
            }
            return minSize == int.MaxValue ? -1 : minSize;
        }
    }
}
