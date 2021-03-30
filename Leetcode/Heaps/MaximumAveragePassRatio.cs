using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class MaximumAveragePassRatio
	{
		public static double maxAverageRatio(int[][] classes, int extraStudents)
		{
			double sumPassRatio = 0;
			PriorityQueue<(int, int)> maxHeap = new PriorityQueue<(int, int)>(classes.Length, Comparer<(int, int)>.Create((a, b) =>
					{
						double d1 = (((double)(a.Item1 + 1) / (double)(a.Item2 + 1)) - ((double)a.Item1 / (double)a.Item2));
						double d2 = (((double)(b.Item1 + 1) / (double)(b.Item2 + 1)) - ((double)b.Item1 / (double)b.Item2));
						return d2.CompareTo(d1);
					}));

			foreach (int[] stuClass in classes)
			{
				maxHeap.Add((stuClass[0], stuClass[1]));
			}

			while(extraStudents > 0)
			{
				int passSize = maxHeap.Peek().Item1;
				int classSize = maxHeap.Peek().Item2;
				maxHeap.Poll();
				maxHeap.Add((passSize + 1, classSize + 1));
				extraStudents--;
			}

			while(maxHeap.Size > 0)
			{
				sumPassRatio += ((double)maxHeap.Peek().Item1 / (double)maxHeap.Peek().Item2);
				maxHeap.Poll();
			}
			return sumPassRatio / (double)classes.Length;
		}
	}
}
