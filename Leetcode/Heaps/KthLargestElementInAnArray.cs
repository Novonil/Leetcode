using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class KthLargestElementInAnArray
	{
		public static int findKthLargest(int[] nums, int k)
		{
			PriorityQueue<int> minHeap = new PriorityQueue<int>();

			foreach(int num in nums)
			{
				minHeap.Add(num);
				if(minHeap.Size > k)
				{
					minHeap.Poll();
				}
			}
			return minHeap.Peek();

		}
	}
}
