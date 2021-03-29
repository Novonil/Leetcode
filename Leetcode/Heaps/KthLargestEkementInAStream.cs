using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class KthLargestEkementInAStream
	{
        PriorityQueue<int> minHeap;
        int K = 0;
        public KthLargestEkementInAStream(int k, int[] nums)
        {
            K = k;
            minHeap = new PriorityQueue<int>();
            foreach(int i in nums)
			{
                minHeap.Add(i);
                if(minHeap.Size > k)
				{
                    minHeap.Poll();
				}
			}
        }

        public int Add(int val)
        {
            minHeap.Add(val);
            if (minHeap.Size > K)
                minHeap.Poll();
            return minHeap.Size > 0 ? minHeap.Peek() : 0;
        }
    }
}
