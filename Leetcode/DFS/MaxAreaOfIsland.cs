using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.DFS
{
	class MaxAreaOfIsland
	{
        public int MaxAreaOfIslands(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int max = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                        max = Math.Max(max, dfs(grid, i, j, rows, cols));
                }
            }
            return max;
        }

        public int dfs(int[][] grid, int i, int j, int rows, int cols)
        {
            if (!isValid(i, j, rows, cols) || grid[i][j] == 0)
                return 0;

            grid[i][j] = 0;

            return 1 + dfs(grid, i - 1, j, rows, cols) + dfs(grid, i + 1, j, rows, cols) + dfs(grid, i, j - 1, rows, cols) + dfs(grid, i, j + 1, rows, cols);
        }

        public bool isValid(int i, int j, int rows, int cols)
        {
            if (i < 0 || i >= rows || j < 0 || j >= cols)
                return false;
            return true;
        }
    }
}
