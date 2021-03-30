using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class SortChractersByFrequency
	{
		public static string FrequencySort(string s)
		{
			StringBuilder sb = new StringBuilder();
			Dictionary<char, int> freqMap = new Dictionary<char, int>();
			PriorityQueue<(int, char)> maxHeap = new PriorityQueue<(int, char)>(s.Length, Comparer<(int, char)>.Create((a, b) => { return b.Item1.CompareTo(a.Item1); }));


			foreach(char c in s)
			{
				if(freqMap.ContainsKey(c))
				{
					freqMap[c]++;
				}
				else
				{
					freqMap.Add(c, 1);
				}
			}

			foreach(KeyValuePair<char,int> kv in freqMap)
			{
				maxHeap.Add((kv.Value, kv.Key));
			}	

			while(maxHeap.Size>0)
			{
				char c = maxHeap.Peek().Item2;
				int freq = maxHeap.Peek().Item1;
				for(int i = 1; i <= freq; i++)
				{
					sb.Append(c);
				}
				maxHeap.Poll();
			}

			return sb.ToString();

		}
	}
}
