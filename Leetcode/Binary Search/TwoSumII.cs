using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class TwoSumII
	{
        public int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;
            int[] result = new int[2];
            int sum = 0;

            while (start < end)
            {
                sum = numbers[start] + numbers[end];
                if (sum == target)
                {
                    result[0] = start + 1;
                    result[1] = end + 1;
                    return result;
                }

                else if (sum > target)
                    end--;

                else
                    start++;
            }

            return result;
        }
    }
}
