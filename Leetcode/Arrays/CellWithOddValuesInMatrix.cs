using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class CellWithOddValuesInMatrix
	{
		public int OddCells(int n, int m, int[][] indices)
		{
			int[,] mat = new int[n, m];
			int count = 0;
			for(int i = 0; i<indices.Length; i++)
			{
				int r = indices[i][0];
				int c = indices[i][1];
				for (int j = 0; j < mat.GetLength(1); j++)
				{
					mat[r, j] = mat[r, j] + 1;
				}

				for (int j = 0; j < mat.GetLength(0); j++)
				{
					mat[j, c] = mat[j, c] + 1;
				}
			}
			for(int i = 0; i<mat.GetLength(0); i++)
			{
				for(int j = 0; j< mat.GetLength(1); j++)
				{
					if (mat[i, j] % 2 != 0)
						count++;
				}
			}
			return count;
		}
	}
}
