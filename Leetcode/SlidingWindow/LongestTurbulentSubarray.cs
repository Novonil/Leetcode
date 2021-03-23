using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class LongestTurbulentSubarray
	{
		public static int MaxTurbulenceSize(int[] arr)
		{
			int size = arr.Length;
			int left = 0;
			int maxTurbulenceValue = 1;

			for(int right = 1; right < size; right++)
			{
				int c = arr[right].CompareTo(arr[right - 1]);
				if(c == 0)
				{
					left = right;
				}
				if(right == size - 1 || c * arr[right + 1].CompareTo(arr[right]) != -1)
				{
					maxTurbulenceValue = Math.Max(maxTurbulenceValue, right - left + 1);
					left = right;
				}
			}
			return maxTurbulenceValue;
		}
	}
}
