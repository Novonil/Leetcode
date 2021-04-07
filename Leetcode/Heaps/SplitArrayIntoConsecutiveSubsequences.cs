using System;
using System.Collections.Generic;
using System.Text;
using NetTopologySuite.Utilities;

namespace Leetcode.Heaps
{
	class SplitArrayIntoConsecutiveSubsequences
	{
		public static bool isPossible(int[] nums)
		{
			int count = 0;
			PriorityQueue<int> maxHeap = new PriorityQueue<int>(nums.Length, Comparer<int>.Create((a,b) => { return b.CompareTo(a); }));

			for(int i = 0; i < nums.Length; i++)
			{
				if(maxHeap.Size == 0 || maxHeap.Peek() + 1 == nums[i])
				{
					maxHeap.Add(nums[i]);
				}
				if(maxHeap.Size == 3)	
				{
					count++;
					maxHeap.Clear();
				}
				if (count >= 2)
					return true;
			}
			return false;
		}
	}
}
