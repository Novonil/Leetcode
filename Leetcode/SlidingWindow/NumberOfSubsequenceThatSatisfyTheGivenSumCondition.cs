using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
    class NumberOfSubsequenceThatSatisfyTheGivenSumCondition
    {
        public int NumSubseq(int[] nums, int target)
        {
            int Mod = (int)Math.Pow(10, 9) + 7;
            int left = 0;
            int right = nums.Length - 1;
            int[] pow2 = new int[nums.Length];
            pow2[0] = 1;
            int result = 0;

            for (int i = 1; i < nums.Length; i++)
                pow2[i] = (pow2[i - 1] * 2) % Mod;

            Array.Sort(nums);
            while (left <= right)
            {
                if (nums[left] + nums[right] <= target)
                {
                    result += (pow2[right - left]) % Mod;
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return result;
        }
    }
}
