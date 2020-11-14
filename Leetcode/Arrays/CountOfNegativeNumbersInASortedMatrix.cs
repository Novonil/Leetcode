using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class CountOfNegativeNumbersInASortedMatrix
	{
		public int CountNegatives(int[][] grid)
		{
			int count = 0, negativeColsFound = 0;
			for(int i = 0; i<grid.Length; i++)
			{
				for(int j = grid[0].Length - 1 - negativeColsFound; j >= 0; j--)
				{
					if(grid[i][j] < 0)
					{
						count += grid.Length - i;
						negativeColsFound++;
					}
					else
					{
						break;
					}
				}
			}
			return count;
		}
	}
}
