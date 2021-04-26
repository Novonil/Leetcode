using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Dynamic_Programming
{
	class HouseRobberII
	{
        public static int Rob(int[] nums)
        {
            int len = nums.Length;

            if (len == 0)
                return 0;

            if (len == 1)
                return nums[0];

            int max1 = Rob(nums, 0, len - 2);
            int max2 = Rob(nums, 1, len - 1);

            return Math.Max(max1, max2);
        }

        public static int Rob(int[] nums, int start, int i)
        {
            if (i < start)
                return 0;

            return Math.Max(Rob(nums, start, i - 2) + nums[i], Rob(nums, start, i - 1));
        }

        static int[] memo;
        public static int Robs(int[] nums)
        {
            int len = nums.Length;
            memo = new int[len];

            if (len == 0)
                return 0;

            if (len == 1)
                return nums[0];
            Array.Fill(memo, -1);
            int max1 = Rob(nums, 0, len - 2);
            Array.Fill(memo, -1);
            int max2 = Rob(nums, 1, len - 1);

            return Math.Max(max1, max2);
        }

        public static int Robs(int[] nums, int start, int i)
        {
            if (i < start)
                return 0;
            if (memo[i] > -1)
                return memo[i];

            memo[i] = Math.Max(Robs(nums, start, i - 2) + nums[i], Robs(nums, start, i - 1));
            return memo[i];
        }

        public static int Robbed(int[] nums)
        {
            int len = nums.Length;
            if (len == 0)
                return 0;
            if (len == 1)
                return nums[0];

            int max1 = Robbed(nums, 0, len - 2);
            int max2 = Robbed(nums, 1, len - 1);

            return Math.Max(max1, max2);
        }
        public static int Robbed(int[] nums, int start, int end)
        {
            int[] dp = new int[nums.Length + 1];
            dp[0] = 0;
            dp[1] = nums[start];

            for (int i = start + 1; i <= end; i++)
            {
                dp[i + 1] = Math.Max(dp[i - 1] + nums[i], dp[i]);
            }
            return dp[end];
        }

        public static int Robbing(int[] nums)
        {
            int len = nums.Length;
            if (len == 0)
                return 0;
            if (len == 1)
                return nums[0];

            int max1 = Robbing(nums, 0, len - 2);
            int max2 = Robbing(nums, 1, len - 1);

            return Math.Max(max1, max2);
        }
        public static int Robbing(int[] nums, int start, int end)
        {
            int prev1 = 0;
            int prev2 = 0;
            for (int i = start; i <= end; i++)
            {
                int temp = prev1;
                prev1 = Math.Max(prev2 + nums[i], prev1);
                prev2 = temp;
            }
            return prev1;
        }
    }
}
