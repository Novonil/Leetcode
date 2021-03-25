using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class LongestContinuousSubarrayWithAbsoluteDifferenceLessThanOrEqualToLimit
	{
        public static int LongestSubarray(int[] nums, int limit)
        {
            int size = nums.Length;
            int left = 0;
            int right = 0;
            int maxSubstring = 0;
            List<int> max = new List<int>();
            List<int> min = new List<int>();

            while (right < size)
            {
                while (max.Count > 0 && max[max.Count - 1] < nums[right])
                {
                    max.RemoveAt(max.Count - 1);
                }
                max.Add(nums[right]);

                while (min.Count > 0 && min[min.Count - 1] > nums[right])
                {
                    min.RemoveAt(min.Count - 1);
                }
                min.Add(nums[right]);

                if (max.Count > 0 && min.Count > 0 && Math.Abs(max[0] - min[0]) > limit)
                {
                    while (max.Count > 0 && min.Count > 0 && Math.Abs(max[0] - min[0]) > limit)
                    {
                        if (max[0] == nums[left])
                        {
                            max.RemoveAt(0);
                        }
                        if (min[0] == nums[left])
                        {
                            min.RemoveAt(0);
                        }
                        left++;
                    }
                }
                maxSubstring = Math.Max(maxSubstring, right - left + 1);
                right++;
            }
            return maxSubstring;
        }
    }
}
