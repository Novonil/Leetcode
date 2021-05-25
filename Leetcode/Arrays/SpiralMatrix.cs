using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class SpiralMatrix
	{
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();
            if (matrix == null || matrix.Length == 0)
                return result;

            int top = 0;
            int bottom = matrix.Length - 1;
            int left = 0;
            int right = matrix[0].Length - 1;

            int size = matrix.Length * matrix[0].Length;

            while (result.Count < size)
            {
                for (int i = left; i <= right && result.Count < size; i++)
                {
                    result.Add(matrix[top][i]);
                }
                top++;

                for (int i = top; i <= bottom && result.Count < size; i++)
                {
                    result.Add(matrix[i][right]);
                }
                right--;

                for (int i = right; i >= left && result.Count < size; i--)
                {
                    result.Add(matrix[bottom][i]);
                }
                bottom--;

                for (int i = bottom; i >= top && result.Count < size; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }

            return result;
        }
    }
}
