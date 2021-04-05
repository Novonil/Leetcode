using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class DistantBarcodesPractice
	{
		public static int[] RearrangeBarcodes(int[] barcodes)
		{
			Dictionary<int, int> freqMap = new Dictionary<int, int>();
			int[] result = new int[barcodes.Length];
			foreach(int barcode in barcodes)
			{
				if(freqMap.ContainsKey(barcode))
				{
					freqMap[barcode]++;
				}
				else
				{
					freqMap.Add(barcode,1);
				}
			}


			PriorityQueue<(int,int)> maxHeap = new PriorityQueue<(int,int)>(freqMap.Count, Comparer<(int,int)>.Create((a,b) => 
			{ 
				int res =  b.Item1.CompareTo(a.Item1); 
				if(res == 0)
				{
					res = b.Item2.CompareTo(a.Item2);
				}
				return res;
			}));

			foreach(KeyValuePair<int,int> kv in freqMap)
			{
				maxHeap.Add((kv.Value,kv.Key));
			}
			int i = 0;
			while(maxHeap.Size >= 2)
			{
				int topFreq = maxHeap.Peek().Item1;
				int topNum = maxHeap.Peek().Item2;
				topFreq--;
				maxHeap.Poll();
				int secFreq = maxHeap.Peek().Item1;
				int secNum = maxHeap.Peek().Item2;
				secFreq--;
				maxHeap.Poll();

				result[i++] = topNum;
				result[i++] = secNum;

				if (topFreq > 0)
				{
					maxHeap.Add((topFreq, topNum));
				}
				if(secFreq > 0)
				{
					maxHeap.Add((secFreq, secNum));
				}
			}

			if(maxHeap.Size == 1)
			{
				result[i++] = maxHeap.Peek().Item2;
				maxHeap.Poll();
			}
			return result;
		}
	}
}
