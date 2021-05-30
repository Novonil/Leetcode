using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class SearchA2DMatrixII
	{
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int row = 0;
            int col = matrix[0].Length - 1;

            while (row < matrix.Length && col >= 0)
            {
                if (matrix[row][col] == target)
                    return true;
                else if (matrix[row][col] < target)
                    row++;
                else
                    col--;
            }
            return false;
        }

        public bool SearchMatrix1(int[][] matrix, int target)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                if (binarySearch(matrix[row], target, 0, matrix[0].Length - 1))
                    return true;
            }
            return false;
        }

        public bool binarySearch(int[] nums, int target, int start, int end)
        {
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                    return true;

                else if (nums[mid] < target)
                    start = mid + 1;

                else
                    end = mid - 1;
            }
            return false;
        }
        public bool SearchMatrix2(int[][] matrix, int target)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    if (matrix[row][col] == target)
                        return true;
                }
            }
            return false;
        }
    }
}
