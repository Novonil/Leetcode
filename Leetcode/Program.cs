using Leetcode.Arrays;
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
			int[] nums1 = { 1, 2, 1 };
			int[] nums2 = { 1, 3, 4, 2 };
			int[] result = Stack.NextGreaterElement2.NextGreaterElements(nums1);
			foreach (int r in result)
			{
				Console.WriteLine(r + " ");
			}
			Console.Read();
		}
	}
}
