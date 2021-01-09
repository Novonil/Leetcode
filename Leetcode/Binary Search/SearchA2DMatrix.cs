using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class SearchA2DMatrix
	{
		public static bool SearchMatrix(int[][] matrix, int target)
		{
			int m = matrix.Length;
			int n = matrix[0].Length;

			int start = 0;
			int end = m * n - 1;
			int mid;
			int row;
			int col;

			while(start <= end)
			{
				mid = start + ((end - start) / 2);
				row = (int) mid / n;
				col = mid % n;
				if(matrix[row][col] == target)
				{
					return true;
				}
				else if(matrix[row][col] < target)
				{
					start = mid + 1;
				}
				else
				{
					end = mid - 1;
				}
			}

			return false;
		}
		public static bool SearchMatrixBruteForce(int[][] matrix, int target)
		{
			for(int i = 0; i < matrix.Length; i++)
			{
				for(int j = 0; j<matrix[0].Length; j++)
				{
					if(matrix[i][j] == target)
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
