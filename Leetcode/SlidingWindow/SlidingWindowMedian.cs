using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class SlidingWindowMedian
	{
		//public static double[] MedianSlidingWindow(int[] nums, int k)
		//{
		//	int i = 0;
		//	int c = 0;
		//	int balance = 0;
		//	int size = nums.Length;
		//	double[] result = new double[size - k + 1];

		//	SortedSet<int> lo = new SortedSet<int>(Comparer<int>.Create((a,b) =>
		//	{
		//		int result = b.CompareTo(a);
		//		return result;
		//	}));
		//	SortedSet<int> hi = new SortedSet<int>();

		//	while(i<k)
		//	{
		//		lo.Add(nums[i++]);
		//	}
		//	for(int j = 0; j < k/2; j++)
		//	{
		//		hi.Add(lo.First());
		//		lo.ElementAt(0);
		//	}

		//	while(true)
		//	{
		//		result[c++] = i % 2 == 0 ? (hi.First() + lo.First() * 0.5): lo.First();

		//		if (i > size)
		//			break;

		//		int out_num = nums[i - k];
		//		int in_num = nums[i++];
		//		balance = 0;
				


		//	}
		//}

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
