using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class LastStoneWeight
	{
		public static int lastStoneWeight(int[] stones)
		{
			PriorityQueue<int> maxHeap = new PriorityQueue<int>(stones.Length, Comparer<int>.Create((a, b) => { return b.CompareTo(a); }));

			foreach (int stone in stones)
			{
				maxHeap.Add(stone);
			}

			while(maxHeap.Size >= 2)
			{
				int y = maxHeap.Peek();
				maxHeap.Poll();
				int x = maxHeap.Peek();
				maxHeap.Poll();
				if(y - x != 0)
				{
					maxHeap.Add(y - x);
				}
			}
			return maxHeap.Size == 1 ? maxHeap.Peek() : 0;
		}
	}
}
