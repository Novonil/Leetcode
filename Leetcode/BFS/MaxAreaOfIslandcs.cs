using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.BFS
{
	class MaxAreaOfIslandcs
	{
        public static int MaxAreaOfIsland(int[][] grid)
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
                        max = Math.Max(max, bfs(grid, i, j, rows, cols));
                }
            }
            return max;
        }

        public static int bfs(int[][] grid, int i, int j, int rows, int cols)
        {
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((i, j));
            grid[i][j] = 0;
            int area = 0;
            while (queue.Count > 0)
            {
                area++;
                int row = queue.Peek().Item1;
                int col = queue.Peek().Item2;

                queue.Dequeue();
                

                if (row - 1 >= 0 && grid[row - 1][col] == 1)
				{
                    queue.Enqueue((row - 1, col));
                    grid[row - 1][col] = 0;
                }


                if (row + 1 < rows && grid[row + 1][col] == 1)
                {
                    queue.Enqueue((row + 1, col));
                    grid[row + 1][col] = 0;
                }

                if (col - 1 >= 0 && grid[row][col - 1] == 1)
                {
                    queue.Enqueue((row, col - 1));
                    grid[row][col - 1] = 0;
                }

                if (col + 1 < cols && grid[row][col + 1] == 1)
                {
                    queue.Enqueue((row, col + 1));
                    grid[row][col + 1] = 0;
                }

            }
            return area;
        }
    }
}
