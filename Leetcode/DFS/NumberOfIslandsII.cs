using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.DFS
{
	class NumberOfIslandsII
	{
        bool[][] visited;
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int rows = grid.Length;
            int cols = grid[0].Length;
            visited = new bool[rows][];
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                visited[i] = new bool[cols];
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == '1' && !visited[i][j])
                    {
                        count += dfs(grid, i, j);
                    }
                }
            }
            return count;
        }

        public int dfs(char[][] grid, int i, int j)
        {
            if (!isValid(grid, i, j) || visited[i][j] || grid[i][j] == '0')
                return 0;

            visited[i][j] = true;

            dfs(grid, i + 1, j);
            dfs(grid, i - 1, j);
            dfs(grid, i, j + 1);
            dfs(grid, i, j - 1);

            return 1;
        }

        public bool isValid(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length)
                return false;
            return true;
        }

        public int NumOfIslands(char[][] grid)
        {
            int count = 0;
            if (grid == null || grid.Length == 0)
                return 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count += dfss(grid, i, j);
                    }
                }
            }
            return count;
        }

        public int dfss(char[][] grid, int i, int j)
        {
            if (!isValids(grid, i, j) || grid[i][j] == '0')
                return 0;

            grid[i][j] = '0';

            dfss(grid, i + 1, j);
            dfss(grid, i - 1, j);
            dfss(grid, i, j + 1);
            dfss(grid, i, j - 1);

            return 1;
        }

        public bool isValids(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length)
                return false;

            return true;
        }
    }
}
