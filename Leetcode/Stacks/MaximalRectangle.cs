using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class MaximalRectangle
	{
        public int MaximalRectangleArea(int[][] matrix)
        {
            if (matrix.Length == 0)
                return 0;

            int max = 0;
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int[] heights = new int[cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        heights[j] = 0;
                    }
                    else
                    {
                        heights[j] += 1;
                    }
                }
                max = Math.Max(max, maxAreaHistogram(heights));
            }
            return max;
        }
        public int maxAreaHistogram(int[] heights)
        {
            int max = 0;
            int len = heights.Length;

            int[] left = nearestSmallerToLeft(heights);
            int[] right = nearestSmallerToRight(heights);

            for (int i = 0; i < len; i++)
            {
                max = Math.Max(max, ((right[i] - left[i] - 1) * heights[i]));
            }
            return max;
        }

        public int[] nearestSmallerToLeft(int[] heights)
        {
            int len = heights.Length;
            int[] left = new int[len];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < len; i++)
            {
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                    stack.Pop();
                left[i] = stack.Count == 0 ? -1 : stack.Peek();
                stack.Push(i);
            }
            return left;
        }

        public int[] nearestSmallerToRight(int[] heights)
        {
            int len = heights.Length;
            int[] right = new int[len];
            Stack<int> stack = new Stack<int>();

            for (int i = len - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                    stack.Pop();
                right[i] = stack.Count == 0 ? len : stack.Peek();
                stack.Push(i);
            }
            return right;
        }
    }
}
