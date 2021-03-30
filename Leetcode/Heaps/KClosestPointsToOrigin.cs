using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class KClosestPointsToOrigin
	{
		public static int[][] KClosest(int[][] points, int k)
		{
			int[][] result = new int[k][];
			PriorityQueue<(int,int,int)> maxHeap = new PriorityQueue<(int,int,int)>(k, Comparer<(int,int,int)>.Create((a, b) => { return b.Item1.CompareTo(a.Item1); }));

			foreach(int[] point in points)
			{
				int distance = (point[0] * point[0]) + (point[1] * point[1]);
				maxHeap.Add((distance, point[0], point[1]));

				if (maxHeap.Size > k)
					maxHeap.Poll();
			}

			int i = 0;
			while(maxHeap.Size > 0)
			{
				int x = maxHeap.Peek().Item2;
				int y = maxHeap.Peek().Item3;
				result[i++] = new int[] { x, y };
				maxHeap.Poll();
			}
			return result;
		}
	}
}
