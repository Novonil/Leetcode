using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class DistantBarcodes
	{
		public static int[] RearrangeBarcodes(int[] barcodes)
		{
			List<int> result = new List<int>();
			Dictionary<int, int> freqMap = new Dictionary<int, int>();
			PriorityQueue<(int, int)> maxHeap = new PriorityQueue<(int, int)>(barcodes.Length, Comparer<(int, int)>.Create((a, b) =>
			{
				int res = b.Item1.CompareTo(a.Item1);
				if (res == 0)
				{
					res = b.Item2.CompareTo(a.Item2);
				}
				return res;
			}));

			foreach(int barcode in barcodes)
			{
				if(freqMap.ContainsKey(barcode))
				{
					freqMap[barcode]++;
				}
				else
				{
					freqMap.Add(barcode, 1);
				}
			}

			foreach (KeyValuePair<int,int> kv in freqMap)
			{
				maxHeap.Add((kv.Value,kv.Key));
			}

			while(maxHeap.Size >= 2)
			{
				int first = maxHeap.Peek().Item2;
				int firstFreq = maxHeap.Peek().Item1;
				maxHeap.Poll();
				int second = maxHeap.Peek().Item2;
				int secondFreq = maxHeap.Peek().Item1;
				maxHeap.Poll();
				firstFreq--;
				secondFreq--;
				result.Add(first);
				result.Add(second);
				if (firstFreq > 0)
				{
					maxHeap.Add((firstFreq,first));
				}
				if(secondFreq > 0)
				{
					maxHeap.Add((secondFreq,second));
				}
			}
			if (maxHeap.Size == 1)
				result.Add(maxHeap.Peek().Item2);
				
			return result.ToArray();
		}
	}
}
