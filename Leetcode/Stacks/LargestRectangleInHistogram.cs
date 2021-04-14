using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class LargestRectangleInHistogram
	{
        public int LargestRectangleArea(int[] heights)
        {
            int len = heights.Length;
            int[] left = new int[len];
            int[] right = new int[len];
            int max = 0;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < len; i++)
            {
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                    stack.Pop();
                left[i] = stack.Count == 0 ? -1 : stack.Peek();
                stack.Push(i);
            }
            stack.Clear();
            for (int i = len - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                    stack.Pop();
                right[i] = stack.Count == 0 ? len : stack.Peek();
                stack.Push(i);
            }
            for (int i = 0; i < len; i++)
            {
                max = Math.Max(max, (right[i] - left[i] - 1) * heights[i]);
            }
            return max;
        }
    }
}
