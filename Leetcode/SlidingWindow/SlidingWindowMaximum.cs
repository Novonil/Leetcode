using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class SlidingWindowMaximum
	{
		public static int[] MaxSlidingWindow(int[] nums, int k)
		{
			int i = 0, j = 0, l = 0;
			int maxNumber = int.MinValue;
			int[] result = new int[nums.Length - k + 1];
			
			while(j != nums.Length)
			{
				maxNumber = Math.Max(maxNumber, nums[j]);

				if (j-i+1 < k)
				{
					j++;
				}
				else
				{
					result[l++] = maxNumber;
					if(nums[i] == maxNumber)
					{
						maxNumber = int.MinValue;
						for(int m = i+1; m <= j; m++)
						{
							maxNumber = Math.Max(maxNumber, nums[m]);
						}
					}
					
					i++;
					j++;
				}
			}
			return result;
		}

		//public static int[] MaxSlidingWindowOptimized(int[] nums, int k)
		//{
		//	int i = 0;
		//	Deque 
		//	return result;
		//}
	}
}
