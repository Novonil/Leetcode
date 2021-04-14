using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class NextGreaterElementII
	{
        public int[] NextGreaterElements(int[] nums)
        {
            //int[] modifiedNums = nums.Concat(nums).ToArray();
            Stack<int> stack = new Stack<int>();
            int len = nums.Length;

            int[] result = new int[nums.Length];

            for (int i = 2 * len - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek() <= nums[i % len])
                {
                    stack.Pop();
                }
                if (i < nums.Length)
                {
                    result[i] = stack.Count > 0 ? stack.Peek() : -1;
                }
                stack.Push(nums[i % len]);
            }
            return result;
        }
    }
}
