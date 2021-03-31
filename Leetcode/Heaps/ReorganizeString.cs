using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class ReorganizeString
	{
		public static string ReorganizeStringFunc(string S)
		{
			StringBuilder result = new StringBuilder();
			Dictionary<char, int> freqMap = new Dictionary<char, int>();
			PriorityQueue<(int, char)> maxHeap = new PriorityQueue<(int, char)>(S.Length, Comparer<(int,char)>.Create((a,b) => 
				{ 
					int res = b.Item1.CompareTo(a.Item1);
					if (res == 0)
						res = a.Item2.CompareTo(b.Item2);
					return res;
				}));

			foreach(char c in S)
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
				maxHeap.Add((kv.Value,kv.Key));
			}

			while(maxHeap.Size >= 2)
			{
				int first = maxHeap.Peek().Item1;
				char fChar = maxHeap.Peek().Item2;
				maxHeap.Poll();
				int second = maxHeap.Peek().Item1;
				char sChar = maxHeap.Peek().Item2;
				maxHeap.Poll();
				result.Append(fChar);
				result.Append(sChar);
				first--;
				second--;
				if(first != 0)
				{
					maxHeap.Add((first,fChar));
				}
				if(second != 0)
				{
					maxHeap.Add((second,sChar));
				}
			}
			if (maxHeap.Size == 1 && maxHeap.Peek().Item1 > 1)
				return "";
			else if (maxHeap.Size == 1)
				return result.Append(maxHeap.Peek().Item2).ToString();
			else
				return result.ToString();
		}
	}
}
