using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class TpKFrequentElements
	{
		public static int[] topKFrequent(int[] nums, int k)
		{
			Dictionary<int, int> freqMap = new Dictionary<int, int>();
			PriorityQueue<(int, int)> minHeap = new PriorityQueue<(int, int)>();

			int[] result = new int[k];

			foreach(int num in nums)
			{
				if(freqMap.ContainsKey(num))
				{
					freqMap[num]++;
				}
				else
				{
					freqMap.Add(num, 1);
				}
			}

			foreach(KeyValuePair<int,int> kv in freqMap)
			{
				minHeap.Add((kv.Value, kv.Key));
				if (minHeap.Size > k)
					minHeap.Poll();
			}

			int i = 0;
			while(minHeap.Size > 0)
			{
				result[i++] = minHeap.Peek().Item2;
				minHeap.Poll();
			}
			return result;
		}
	}
}
