﻿using Leetcode.Arrays;
using Leetcode.Binary_Search;
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
			int[] num1 = { 2, 7, 11, 15 };//, 0, 0, 0 };
			int[] num2 = { 1, 0 };//, 1, 1, 0 };
			int[] num3 = { 1, 0 };//, 0, 0, 0 };
			int[] num4 = { 1, 1 };//, 0, 0, 0 };
			int[] num5 = { 1, 1, 1, 1, 1 };

			int[][] nums = new int[4][];
			nums[0] = num1;
			nums[1] = num2;
			nums[2] = num3;
			nums[3] = num4;
			//nums[4] = num5;


			//Console.WriteLine(SearchInARotatedSortedArray.Search(nums, 4));
			CustomFunction customfunction = new CustomFunction();
			//Console.WriteLine(FindPositiveIntegerSolutionForAGivenEquation.FindSolution(customfunction, 6));
			//int[] arr = /*MedianOfTwoSortedArrays.FindMedianSortedArrays*/(num1,num2);

			//IList<IList<int>> l = new List<IList<int>>();
			int[] l = TwoSumIIArrayIsSorted.TwoSum(num1, 9);

			foreach (int i in l)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();
		}
	}
}