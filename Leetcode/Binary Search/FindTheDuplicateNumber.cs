using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class FindTheDuplicateNumber
	{
		public static int FindDuplicateBruteForce(int[] nums)
		{
			HashSet<int> numbersVisited = new HashSet<int>();

			foreach (int i in nums)
			{
				if (numbersVisited.Contains(i))
					return i;
				numbersVisited.Add(i);
			}
			return -1;
		}
		public static int FindDuplicateTortoiseHareProblem(int[] nums)
		{
			int tortoise = nums[0];
			int hare = nums[0];

			do
			{
				hare = nums[nums[hare]];
				tortoise = nums[tortoise];
			} while (hare != tortoise);

			tortoise = nums[0];

			while (hare!=tortoise)
			{
				hare = nums[hare];
				tortoise = nums[tortoise];
			}
			return hare;
		}

		public static int FindDuplicateBinarySearch(int[] nums)
		{
			int start = 1;
			int end = nums.Length - 1;
			int mid = 0;


			while (start < end)
			{
				mid = start + (end - start) / 2;

				int count = 0;
				foreach (int num in nums)
				{
					if (num <= mid)
					{
						count++;
					}
				}
				if (count > mid)
				{
					end = mid;
				}
				else
				{
					start = mid + 1;
				}
			}
			return start;
		}
	}
}
