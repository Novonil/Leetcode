using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class KthSmallestElementInASortedMatrix
	{
		public static int KthSmallest(int[][] matrix, int k)
		{
			int n = matrix.Length;
			int start = matrix[0][0];
			int end = matrix[n - 1][n - 1];
			int mid;

			while(start < end)
			{
				mid = start + (end - start) / 2;

				int row = n - 1;
				int col = 0;
				int sizeOfLeft = 0;
				int l = int.MinValue;
				int r = int.MaxValue;

				while(row >= 0 && col < n)
				{
					if(matrix[row][col] <= mid)
					{
						l = Math.Max(l,matrix[row][col]);
						sizeOfLeft += row + 1;
						col++;

					}
					else
					{
						r = Math.Min(r,matrix[row][col]);
						row--;
					}
				}

				if (sizeOfLeft == k)
					return l;
				else if(sizeOfLeft > k)
				{
					end = l;
				}
				else
				{
					start = r;
				}
			}
			return start;
		}
	}
}
