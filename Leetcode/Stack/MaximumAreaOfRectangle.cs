using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	class MaximumAreaOfRectangle
	{
		public static int LargestRectangleArea(int[] heights)
		{
			if (heights.Length == 0)
				return 0;

			int max = int.MinValue;
			int n = heights.Length;
			int[] nearestSmallerLeft = new int[n];
			int[] nearestSmallerRight = new int[n];
			int[] area = new int[n];
			Stack<(int,int)> leftStack = new Stack<(int,int)>();
			Stack<(int,int)> rightStack = new Stack<(int,int)>();

			for(int i = 0; i < n; i++)
			{
				while(leftStack.Count > 0 && leftStack.Peek().Item1 >= heights[i])
				{
					leftStack.Pop();
				}
				if(leftStack.Count == 0)
				{
					nearestSmallerLeft[i] = -1;
				}
				else
				{
					nearestSmallerLeft[i] = leftStack.Peek().Item2;
				}
				leftStack.Push((heights[i],i));
			}

			for(int i = n-1; i >= 0; i--)
			{
				while(rightStack.Count > 0 && rightStack.Peek().Item1 >= heights[i])
				{
					rightStack.Pop();
				}
				if(rightStack.Count == 0)
				{
					nearestSmallerRight[i] = n;
				}
				else
				{
					nearestSmallerRight[i] = rightStack.Peek().Item2;
				}
				rightStack.Push((heights[i],i));
			}	

			for(int i = 0; i<n; i++)
			{
				max = Math.Max(max, (nearestSmallerRight[i] - nearestSmallerLeft[i] - 1) * heights[i]);
			}
			return max;
		}
	}
}
