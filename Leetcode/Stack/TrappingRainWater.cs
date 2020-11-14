using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	class TrappingRainWater
	{
		public static int Trap(int[] height)
		{
			if (height.Length == 0)
			{
				return 0;
			}
			int sum = 0;
			int n = height.Length;
			int[] maxLeft = new int[n];
			int[] maxRight = new int[n];

			maxLeft[0] = height[0];
			maxRight[n - 1] = height[n - 1];

			for (int i = 1; i < n; i++)
			{
				maxLeft[i] = Math.Max(maxLeft[i - 1], height[i]);
			}

			for (int i = n - 2; i >= 0; i--)
			{
				maxRight[i] = Math.Max(maxRight[i + 1], height[i]);
			}

			for (int i = 0; i < n; i++)
			{
				sum += Math.Min(maxLeft[i], maxRight[i]) - height[i];
			}
			return sum;
		}


		public static int TrapOptimizeStack(int[] height)
		{
			int amount = 0;
			int n = height.Length;

			if (n == 0)
				return 0;

			Stack<int> s = new Stack<int>();

			for (int i = 0; i < n; i++)
			{
				while (s.Count > 0 && height[s.Peek()] < height[i])
				{
					int top = s.Pop();
					if (s.Count == 0)
						break;
					int dist = i - s.Peek() - 1;
					amount += (Math.Min(height[i], height[s.Peek()]) - height[top]) * dist;
				}
				s.Push(i);
			}
			return amount;
		}



		public static int TrapOptimize(int[] height)
		{
			int amount = 0;
			int n = height.Length;
			if (n == 0)
				return 0;
			int left = 0, right = n - 1, left_max = int.MinValue, right_max = int.MinValue;

			while (left < right)
			{
				if (height[left] < height[right])
				{
					if (height[left] > left_max)
					{
						left_max = height[left];
					}
					else
					{
						amount += left_max - height[left];
					}
					left++;
				}
				else
				{
					if (height[right] > right_max)
					{
						right_max = height[right];
					}
					else
					{
						amount += right_max - height[right];
					}
					right--;
				}
			}
			return amount;
		}
	}
}
