using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class CountNegativeNumbersInASortedMatrix
	{
		public static int CountNegatives(int[][] grid)
		{
			int m = grid.Length;
			int n = grid[0].Length;
			int i = 0;
			int j = n - 1;
			int count = 0;
			while (i < m && j >= 0)
			{
				if(grid[i][j] < 0)
				{
					count += m - i;
					j--;
				}
				else
				{
					i++;
				}
			}
			return count;
		}
		public static int CountNegativesBruteForce(int[][] grid)
		{
			int m = grid.Length;
			int n = grid[0].Length;
			int count = 0;
			for (int i = m - 1; i >= 0; i--)
			{
				for (int j = n - 1; j >= 0; j--)
				{
					if (grid[i][j] < 0)
					{
						count++;
					}
				}
			}
			return count;

		}
		public static int CountNegativesAscending(int [][] grid)
		{
			int m = grid.Length;
			int n = grid[0].Length;
			int count = 0;

			int i = m - 1;
			int j = 0;

			while(i>= 0 && j<n)
			{
				if(grid[i][j] < 0)
				{
					count += i+1;
					j++;
				}
				else
				{
					i--;
				}
			}
			return count;
		}

		public static int CountNegativesBinarySearch(int[][] grid)
		{
			int m = grid.Length;
			int n = grid[0].Length;
			int start = 0;
			int end = n - 1;
			int mid;
			int count = 0;
			int row = 0;
			int lastNegative = n;

			while (row < m)
			{
				if(grid[row][0] < 0)
				{
					count += n - 1;
					continue;
				}
				else if(grid[row][n-1] > 0)
				{
					continue;
				}
				start = 0;
				end = lastNegative - 1;

				while (start <= end)
				{
					mid = start + ((end - start) / 2);
					if (grid[row][mid] < 0)
					{
						lastNegative = mid;
						end = mid - 1;
					}
					else
					{
						start = mid + 1;
					}
				}
				count += n - lastNegative;
				
				row++;
			}
			return count;
		}
	}
}
