using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.DFS
{
	class NumberOfClosedIslands
	{
        public int ClosedIsland(int[][] grid)
        {
            if (grid == null || grid.Length <= 2 || grid[0].Length <= 2)
                return 0;

            int rows = grid.Length;
            int cols = grid[0].Length;

            int numOfIslands = 0;

            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < cols - 1; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        numOfIslands += dfs(grid, i, j);
                    }
                }
            }
            return numOfIslands;
        }

        public int dfs(int[][] grid, int i, int j)
        {
            if (isBoundary(grid, i, j) && grid[i][j] == 0)
                return 0;

            if (!isValid(grid, i, j) || grid[i][j] != 0)
                return 1;

            grid[i][j] = 1;

            int up = dfs(grid, i - 1, j);
            int down = dfs(grid, i + 1, j);
            int left = dfs(grid, i, j - 1);
            int right = dfs(grid, i, j + 1);

            return up * down * left * right;
        }

        public bool isValid(int[][] grid, int i, int j)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            if (i < 0 || i > rows - 1 || j < 0 || j > cols - 1)
                return false;
            return true;
        }

        public bool isBoundary(int[][] grid, int i, int j)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                return true;
            return false;
        }
    }
}
