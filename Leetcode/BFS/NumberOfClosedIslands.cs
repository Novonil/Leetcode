using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.BFS
{
	class NumberOfClosedIslands
	{
        public static int ClosedIsland(int[][] grid)
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
                        numOfIslands += bfs(grid, i, j);
                    }
                }
            }
            return numOfIslands;
        }

        public static int bfs(int[][] grid, int i, int j)
        {
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((i, j));
            bool validIsland = true;
            while (queue.Count > 0)
            {
                int row = queue.Peek().Item1;
                int col = queue.Peek().Item2;
                queue.Dequeue();

                grid[row][col] = 1;

                if (notClosedIsland(grid, row, col))
                    validIsland = false;

                if (isValid(grid, row - 1, col) && grid[row - 1][col] == 0)
                {
                    queue.Enqueue((row - 1, col));
                    grid[row - 1][col] = 1;
                }
                if (isValid(grid, row + 1, col) && grid[row + 1][col] == 0)
                {
                    queue.Enqueue((row + 1, col));
                    grid[row + 1][col] = 1;
                }
                if (isValid(grid, row, col - 1) && grid[row][col - 1] == 0)
                {
                    queue.Enqueue((row, col - 1));
                    grid[row][col - 1] = 1;
                }
                if (isValid(grid, row, col + 1) && grid[row][col + 1] == 0)
                {
                    queue.Enqueue((row, col + 1));
                    grid[row][col + 1] = 1;
                }
            }
            if (validIsland)
                return 1;
            else
                return 0;
        }
        public static bool notClosedIsland(int[][] grid, int row, int col)
        {
            if (isBoundary(grid, row - 1, col) && grid[row - 1][col] == 0)
                return true;

            if (isBoundary(grid, row + 1, col) && grid[row + 1][col] == 0)
                return true;

            if (isBoundary(grid, row, col - 1) && grid[row][col - 1] == 0)
                return true;

            if (isBoundary(grid, row, col + 1) && grid[row][col + 1] == 0)
                return true;

            return false;
        }

        public static bool isBoundary(int[][] grid, int i, int j)
        {
            if (i == 0 || i == grid.Length - 1 || j == 0 || j == grid[0].Length - 1)
                return true;
            return false;
        }
        public static bool isValid(int[][] grid, int i, int j)
        {
            if (i > 0 && i < grid.Length - 1 && j > 0 && j < grid[0].Length - 1)
                return true;
            return false;
        }

    }
}
