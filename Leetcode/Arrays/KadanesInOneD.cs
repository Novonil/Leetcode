using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class KadanesInOneD
	{
		public static int maximumSubarraySum(int[] arr)
		{
			int curr_Sum = arr[0];
			int total_Sum = arr[0];

			for (int i = 1; i < arr.Length; i++)
			{
				curr_Sum = Math.Max(arr[i], curr_Sum + arr[i]);
				//if(curr_Sum >= 0)
				//{
				//	curr_Sum += arr[i];
				//}
				//else
				//{
				//	curr_Sum = arr[i];
				//}
				total_Sum = Math.Max(total_Sum, curr_Sum);
			}
			return total_Sum;
		}

		public static int maximumSubarraySumBruteForce(int[] arr)
		{
			int maxSum = int.MinValue;
			

			for(int i = 0; i< arr.Length; i++)
			{
				int sum = 0;
				for (int j = i; j < arr.Length; j++)
				{
					sum += arr[j];
					maxSum = Math.Max(maxSum, sum);
				}
			}
			return maxSum;
		}

		public static int[] maximumSumSubarray(int[] arr)
		{
			int max_Sum = arr[0];
			int curr_Sum = arr[0];
			int start_Index = 0;
			int last_Start_Index = 0;
			int end_Index = 0;
			List<int> result = new List<int>();

			for(int i =1; i<arr.Length; i++)
			{
				if(curr_Sum >= 0)
				{
					curr_Sum += arr[i];
				}
				else
				{
					curr_Sum = arr[i];
					last_Start_Index = i;
				}
				if(curr_Sum > max_Sum)
				{
					max_Sum = curr_Sum;
					start_Index = last_Start_Index;
					end_Index = i;
				}
			}
			for(int i = start_Index; i<=end_Index;i++)
			{
				result.Add(arr[i]);
			}
			return result.ToArray();
		}
	}
}
