using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.BFS
{
	class NumberOfIslands
	{
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int rows = grid.Length;
            int cols = grid[0].Length;
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        bfs(grid, i, j);
                    }
                }
            }
            return count;
        }

        public void bfs(char[][] grid, int i, int j)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            Queue<(int, int)> queue = new Queue<(int, int)>();

            grid[i][j] = '0';
            queue.Enqueue((i, j));

            while (queue.Count > 0)
            {
                int row = queue.Peek().Item1;
                int col = queue.Peek().Item2;
                queue.Dequeue();

                if (row - 1 >= 0 && grid[row - 1][col] == '1')
                {
                    queue.Enqueue((row - 1, col));
                    grid[row - 1][col] = '0';
                }

                if (row + 1 < rows && grid[row + 1][col] == '1')
                {
                    queue.Enqueue(((row + 1), col));
                    grid[row + 1][col] = '0';
                }

                if (col - 1 >= 0 && grid[row][col - 1] == '1')
                {
                    queue.Enqueue((row, col - 1));
                    grid[row][col - 1] = '0';
                }
                if (col + 1 < cols && grid[row][col + 1] == '1')
                {
                    queue.Enqueue((row, col + 1));
                    grid[row][col + 1] = '0';
                }
            }
        }
    }
}
