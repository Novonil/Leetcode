using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class MinimumSizeSubArraySum
	{
        public int MinSubArrayLenss(int target, int[] nums)
        {
            int ans = int.MaxValue;
            int len = nums.Length;

            for (int left = 0; left < len; left++)
            {
                int sum = 0;
                for (int right = left; right < len; right++)
                {
                    sum += nums[right];

                    if (sum >= target)
                    {
                        ans = Math.Min(right - left + 1, ans);
                        break;
                    }
                }
            }
            return ans == int.MaxValue ? 0 : ans;
        }
        public int MinSubArrayLens(int target, int[] nums)
        {
            int result = int.MaxValue;
            for (int i = 1; i <= nums.Length; i++)
            {
                for (int j = 0; j <= nums.Length - i; j++)
                {
                    int sum = 0;
                    for (int k = j; k < j + i && k < nums.Length; k++)
                    {
                        sum += nums[k];
                    }
                    if (sum >= target)
                        result = Math.Min(result, i);
                }
            }
            return result == int.MaxValue ? 0 : result;
        }
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0;
            int right = 0;
            int len = nums.Length - 1;
            int minSize = int.MaxValue;
            int sum = 0;

            while (right <= len)
            {
                sum += nums[right];

                if (sum >= target)
                {
                    while (left <= len && sum >= target)
                    {
                        minSize = Math.Min(minSize, right - left + 1);
                        sum -= nums[left];
                        left++;

                    }
                }
                right++;
            }
            return minSize == int.MaxValue ? 0 : minSize;
        }
    }
}
