using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class SpiralMatrixII
	{
        public int[][] GenerateMatrix(int n)
        {
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            int count = 1;

            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;

            while (count <= n * n)
            {
                for (int i = left; i <= right; i++)
                {
                    matrix[top][i] = count++;
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    matrix[i][right] = count++;
                }
                right--;

                for (int i = right; i >= left; i--)
                {
                    matrix[bottom][i] = count++;
                }
                bottom--;

                for (int i = bottom; i >= top; i--)
                {
                    matrix[i][left] = count++;
                }
                left++;
            }

            return matrix;
        }
    }
}
