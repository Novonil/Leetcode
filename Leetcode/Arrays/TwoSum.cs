using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class TwoSum
	{
        public int[] TwoSums(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> seen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];

                if (seen.ContainsKey(difference))
                {
                    result[0] = i;
                    result[1] = seen[difference];
                }
                if (!seen.ContainsKey(nums[i]))
                    seen.Add(nums[i], i);
                else
                    seen[nums[i]] = i;
            }
            return result;
        }
    }
}
