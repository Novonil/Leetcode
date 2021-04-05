using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class SumOfDiagonalSubMatrix
	{
		public static int sumMatrix(int[,] arr, int top, int left, int bottom, int right)
		{
			if (left < 0 || right < 0 || left >= arr.GetLength(1) || right >= arr.GetLength(1) || top < 0 || bottom < 0 || top >= arr.GetLength(0) || bottom >= arr.GetLength(0))
				return 0;

			int row = arr.GetLength(0);
			int col = arr.GetLength(1);
			int[,] intermediate = new int[row, col];
			int sum = 0;

			intermediate[0, 0] = arr[0, 0];

			for (int i = 1; i < row; i++)
			{
				intermediate[i, 0] = intermediate[i - 1, 0] + arr[i, 0];
			}
			for (int j = 1; j < col; j++)
			{
				intermediate[0, j] = intermediate[0, j - 1] + arr[0, j];
			}

			for (int i = 1; i < row; i++)
			{
				for (int j = 1; j < col; j++)

				{
					intermediate[i, j] = intermediate[i - 1, j] + intermediate[i, j - 1] - intermediate[i - 1, j - 1] + arr[i, j];
				}
			}

			sum += intermediate[bottom, right];
			sum -= top - 1 < 0 ? 0 : intermediate[top - 1, right];
			sum -= left - 1 < 0 ? 0 : intermediate[bottom, left - 1];
			sum += top - 1 < 0 || left - 1 < 0 ? 0 : intermediate[top-1,left-1];
			
			return sum;
		}
	}
}
