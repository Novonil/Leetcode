using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class MatrixDiagonalSum
	{
		public int DiagonalSum(int[][] mat)
		{
			int sum = 0;
			for(int i = 0; i<mat.Length; i++)
			{
				if(i != mat.Length - 1- i)
				{
					sum += mat[i][i];
					sum += mat[i][mat.Length - 1 - i];
				}
				else
				{
					sum += mat[i][i];
				}
			}
			return sum;
		}
	}
}
