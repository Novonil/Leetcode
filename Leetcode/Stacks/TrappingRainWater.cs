using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class TrappingRainWater
	{
        public int Trap(int[] height)
        {
            int n = height.Length;
            int[] left = new int[height.Length];
            int[] right = new int[height.Length];
            int[] depth = new int[height.Length];
            int maxRight = -1;
            int maxLeft = -1;
            int maxWater = 0;
            for (int i = 0; i < n; i++)
            {
                maxLeft = Math.Max(maxLeft, height[i]);
                maxRight = Math.Max(maxRight, height[n - 1 - i]);
                left[i] = maxLeft;
                right[n - 1 - i] = maxRight;
            }

            for (int i = 0; i < n; i++)
            {
                depth[i] = Math.Min(left[i], right[i]);
                maxWater += Math.Max(depth[i] - height[i], 0);
            }
            return maxWater;
        }
    }
}
