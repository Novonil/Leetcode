﻿using Leetcode.Arrays;
using Leetcode.Binary_Search;
using Leetcode.Heaps;
using Leetcode.SlidingWindow;
using Leetcode.Stack;
using System;
using System.Collections.Generic;

namespace Leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] num1 = { 1, 5, 9 };
			int[] num2 = { 10, 11, 13 };//, 1, 1, 0 };
			int[] num3 = { 12, 13, 15 };//, 0, 0, 0 };
			int[] num4 = { 1, 1 };//, 0, 0, 0 };
			int[] num5 = { 1, 1, 1, 1, 1 };

			int[][] nums = new int[3][];
			nums[0] = num1;
			nums[1] = num2;
			nums[2] = num3;
			//nums[3] = num4;
			//nums[4] = num5;


			//Console.WriteLine(KthSmallestElementInASortedMatrix.KthSmallest(nums, 8	));


			//Console.WriteLine(ArrangingCoins.ArrangeCoins(3));
			//CustomFunction customfunction = new CustomFunction();
			//Console.WriteLine(FindPositiveIntegerSolutionForAGivenEquation.FindSolution(customfunction, 6));
			//int[] arr = /*MedianOfTwoSortedArrays.FindMedianSortedArrays*/(num1,num2);

			//IList<IList<int>> l = new List<IList<int>>();
			//int[] l = TwoSumIIArrayIsSorted.TwoSum(num1, 9);

			//foreach (int i in l)
			//{
			//	Console.WriteLine(i);
			//}
			//int[] num = { 0, 0, 0, 1, 0, 1, 1, 0 };


			//int[] nums1 = { 0, 1, 0, 1, 0, 1, 0, 1 };
			//string s = "ABAB";
			//string t = "havefunonleetcode";

			//int res = MinimumNumberOfKConsecutiveBitFlips.MinKBitFlips(num, 3);

			int[] num = { 4, 5, 8, 2 };
			//int res = LastStoneWeight.lastStoneWeight(num);


			//KthLargestEkementInAStream k = new KthLargestEkementInAStream(3, num);

			//Console.WriteLine(k.Add(3));
			//Console.WriteLine(k.Add(5));
			//Console.WriteLine(k.Add(10));
			//Console.WriteLine(k.Add(9));
			//Console.WriteLine(k.Add(4));


			//int[][] arr = new int[2][];
			//arr[0] = new int[] { 1,3 };
			//arr[1] = new int[] { -2, 2};

			//int[][] res = KClosestPointsToOrigin.KClosest(arr, 1);

			//foreach(int[] r in res)
			//{
			//	Console.WriteLine(r[0] + " , " + r[1]);
			//}


			//string s = "Aabb";
			//Console.WriteLine(SortChractersByFrequency.FrequencySort(s));


			//int[] arr = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };

			//int res = KthLargestElementInAnArray.findKthLargest(arr, 4);
			//foreach (int r in res)

			//string[] s = { "i", "love", "leetcode", "i", "love", "coding" };


			//IList<string> res = TopKFrequentWords.TopKFrequent(s, 2);
			//foreach(string sr in res)
			//{
			//	Console.WriteLine(sr);
			//}

			//int[][] matrix = new int[3][];
			//matrix[0] = new int[] { 1, 5, 9 };
			//matrix[1] = new int[] { 10, 11, 13 };
			//matrix[2] = new int[] { 12, 13, 15 };

			//int res = Heaps.MaximumScoreFromRemovingStones.MaximumScoreHeap(4,4,6);,


			int[][] n = new int[3][];
			n[0] = new int[] { 1,2 };
			n[1] = new int[] { 3, 5 };
			n[2] = new int[] { 2, 2 };

			double res = MaximumAveragePassRatio.maxAverageRatio(n, 2);
			Console.WriteLine(res);
			Console.ReadLine();
		}
	}
}
