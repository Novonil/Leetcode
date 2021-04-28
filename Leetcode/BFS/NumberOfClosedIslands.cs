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
                        numOfIslands += bfs(grid, i, j, rows, cols);
                    }
                }
            }
            return numOfIslands;
        }

        public static int bfs(int[][] grid, int i, int j, int rows, int cols)
        {
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((i, j));
            grid[i][j] = 1;

            while (queue.Count > 0)
            {
                int row = queue.Peek().Item1;
                int col = queue.Peek().Item2;

                queue.Dequeue();


                if (row - 1 == 0 && grid[row - 1][col] == 0)
                    return 0;
                else if (row - 1 > 0 && grid[row - 1][col] == 0)
                {
                    queue.Enqueue((row - 1, col));
                    grid[row - 1][col] = 1;
                }

                if (row + 1 == rows - 1 && grid[row + 1][col] == 0)
                    return 0;
                else if (row + 1 < rows - 1 && grid[row + 1][col] == 0)
                {
                    queue.Enqueue((row + 1, j));
                    grid[row + 1][col] = 1;
                }

                if (col - 1 == 0 && grid[row][col - 1] == 0)
                    return 0;
                else if (col - 1 > 0 && grid[row][col - 1] == 0)
                {
                    queue.Enqueue((row, col - 1));
                    grid[row][col - 1] = 1;
                }

                if (col + 1 == cols - 1 && grid[row][col + 1] == 0)
                    return 0;
                else if (col + 1 < cols - 1 && grid[row][col + 1] == 0)
                {
                    queue.Enqueue((row, col + 1));
                    grid[row][col + 1] = 1;
                }
            }
            return 1;
        }

    }
}
