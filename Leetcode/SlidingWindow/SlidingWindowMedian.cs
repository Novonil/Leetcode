using NetTopologySuite.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class SlidingWindowMedian
	{
		public static double[] MedianSlidingWindow(int[] nums, int k)
		{
			int size = nums.Length;
			int left = 0;
			int right = 0;
			double[] result = new double[size - k + 1];
			//PriorityQueue<int> minHeap = new PriorityQueue<int>();
			//PriorityQueue<int> maxHeap = new PriorityQueue<int>(k/2, );
			//SortedList<int,int> list = new SortedList<int,int>();

			List<int> l = new List<int>();
			


			while (right < size)
			{
				l.Add(nums[right]);
				if (right - left + 1 == k)
				{
					List<int> dup = new List<int>(l);
					dup.Sort();
					if(k % 2 == 0)
					{
						long sum = (long)dup[k / 2 - 1] + (long)dup[k / 2];
						result[left] = sum / 2.0;
					}
					else
					{
						result[left] = (double) dup[k / 2];
					}
					l.Remove(nums[left]);
					left++;
				}
				right++;
			}

			return result;
		}

		public static double[] MedianSlidingWindowBruteForce(int[] nums, int k)
		{

			double[] result = new double[nums.Length - k + 1];

			for(int left = 0; left<nums.Length - k + 1; left++)
			{
				List<int> temp = new List<int>();
				for(int right = left; right < left + k; right++)
				{
					temp.Add(nums[right]);
				}
				temp.Sort();
				if(k % 2 == 0)
				{
					long sum = (long)temp[k / 2 - 1] + (long)temp[k / 2];
					result[left] = sum/2.0;
				}
				else
				{
					result[left] = temp[k / 2];
				}	
			}

			return result;
		}
	}
}
