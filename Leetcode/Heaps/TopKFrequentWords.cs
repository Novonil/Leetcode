using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class TopKFrequentWords
	{
		public static IList<string> TopKFrequent(string[] words, int k)
		{
			string[] result = new string[k];
			Dictionary<string, int> freqMap = new Dictionary<string, int>();
			PriorityQueue<(int, string)> minHeap = new PriorityQueue<(int, string)>(k,Comparer<(int,string)>.Create((a,b) => 
			{ 
				int res = a.Item1.CompareTo(b.Item1);
				if (res == 0)
				{
					res = b.Item2.CompareTo(a.Item2);
				}
				return res;
			}));

			foreach(string word in words)
			{
				if(freqMap.ContainsKey(word))
				{
					freqMap[word]++;
				}
				else
				{
					freqMap.Add(word, 1);
				}
			}

			foreach(KeyValuePair<string,int> kv in freqMap)
			{
				minHeap.Add((kv.Value, kv.Key));
				if(minHeap.Size > k)
				{
					minHeap.Poll();
				}
			}

			int i = k - 1;
			while(minHeap.Size > 0)
			{
				result[i--] = minHeap.Peek().Item2;
				minHeap.Poll();
			}

			return result;
		}
	}
}
