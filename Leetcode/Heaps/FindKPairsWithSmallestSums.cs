using System;
using System.Collections.Generic;
using System.Text;
using NetTopologySuite.Utilities;

namespace Leetcode.Heaps
{
	class FindKPairsWithSmallestSums
	{
		public static List<List<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
		{
			List<List<int>> result = new List<List<int>>();
			PriorityQueue<(int, int)> maxHeap = new PriorityQueue<(int, int)>(k, Comparer<(int, int)>.Create((a, b) => { return (b.Item1 + b.Item2).CompareTo(a.Item1 + a.Item2); }));

			foreach(int num1 in nums1)
			{
				foreach(int num2 in nums2)
				{
					maxHeap.Add((num1, num2));
					if(maxHeap.Size > k)
					{
						maxHeap.Poll();
					}
				}
			}

			while(maxHeap.Size > 0)
			{
				List<int> res = new List<int>();
				res.Add(maxHeap.Peek().Item1);
				res.Add(maxHeap.Peek().Item2);
				result.Add(res);
				maxHeap.Poll();
			}

			return result;
		}

		public static List<List<int>> kSmallestPairs(int[] nums1, int[] nums2, int k)
		{
			List<List<int>> result = new List<List<int>>();
			PriorityQueue<(int, int)> minHeap = new PriorityQueue<(int, int)>(k, Comparer<(int, int)>.Create((a, b) => { return (nums1[a.Item1] + nums2[a.Item2]).CompareTo(nums1[b.Item1] + nums2[b.Item2]); }));

			for(int i = 0; i < nums2.Length; i++)
			{
				minHeap.Add((0,i));
			}

			while(k > 0 && minHeap.Size > 0)
			{
				var top = minHeap.Peek();
				minHeap.Poll();
				List<int> res = new List<int>();
				res.Add(nums1[top.Item1]);
				res.Add(nums2[top.Item2]);
				result.Add(res);
				k--;
				if(top.Item1 + 1 < nums1.Length)
				{
					minHeap.Add((top.Item1 + 1,top.Item2));
				}
			}
			return result;
		}
	}
}
