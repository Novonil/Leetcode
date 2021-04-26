using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Dynamic_Programming
{
	class HouseRobber
	{
        public static int Rob(int[] nums)
        {
            int len = nums.Length - 1;
            return Rob(nums, len);
        }

        public static int Rob(int[] nums, int i)
        {
            if (i < 0)
                return 0;

            return Math.Max(Rob(nums, i - 2) + nums[i], Rob(nums, i - 1));

        }

        static int[] dp;
        public static int Robbed(int[] nums)
        {
            int len = nums.Length - 1;
            dp = new int[len + 1];
            Array.Fill(dp, -1);
            return Robbed(nums, len);
        }

        public static int Robbed(int[] nums, int i)
        {
            if (i < 0)
                return 0;

            if (dp[i] >= 0)
            {
                return dp[i];
            }

            dp[i] = Math.Max(Robbed(nums, i - 2) + nums[i], Robbed(nums, i - 1));
            return dp[i];
        }

        public static int Robs(int[] nums)
        {
            int len = nums.Length;
            int[] dp = new int[len + 1];

            dp[0] = 0;
            dp[1] = nums[0];

            for (int i = 1; i < len; i++)
            {
                dp[i + 1] = Math.Max(dp[i - 1] + nums[i], dp[i]);
            }
            return dp[len];
        }

        public static int Robbes(int[] nums)
        {
            int prev1 = 0;
            int prev2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = prev1;
                prev1 = Math.Max(prev2 + nums[i], prev1);
                prev2 = temp;
            }
            return prev1;
        }
    }
}
