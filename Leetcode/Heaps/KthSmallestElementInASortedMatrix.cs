using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class KthSmallestElementInASortedMatrix
	{
		public static int kthSmallest(int[][] matrix, int k)
		{
			int result = 0;
			int rows = matrix.Length;
			int cols = matrix[0].Length;
			int heapSize = Math.Min(rows, k);
			PriorityQueue<(int, int, int)> minHeap = new PriorityQueue<(int, int, int)>(heapSize, Comparer<(int,int,int)>.Create((a,b) => { return a.Item1.CompareTo(b.Item1); }));

			for(int row = 0; row < heapSize; row++)
			{
				minHeap.Add((matrix[row][0],row,0));
			}

			while(k > 0)
			{
				result = minHeap.Peek().Item1;
				int poppedRow = minHeap.Peek().Item2;
				int poppedcolumn = minHeap.Peek().Item3;
				minHeap.Poll();
				if(poppedcolumn + 1 <= cols - 1)
					minHeap.Add((matrix[poppedRow][poppedcolumn + 1], poppedRow, poppedcolumn + 1));

				k--;
			}
			return result;
		}
	}
}
