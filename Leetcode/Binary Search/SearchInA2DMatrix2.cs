using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class SearchInA2DMatrix2
	{
		public bool SearchMatrix(int[][] matrix, int target)
		{
			int m = matrix.Length;
			int n = matrix[0].Length;
			int i = 0;
			int j = n - 1;

			while (i < m && j >= 0)
			{
				if (matrix[i][j] == target)
				{
					return true;
				}
				else if (matrix[i][j] > target)
				{
					j--;
				}
				else
				{
					i++;
				}
			}
			return false;
		}

	}
}
