using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.BFS
{
	class SuroundedRegions
	{
        public static void Solve(char[][] board)
        {
            if (board == null || board.Length == 0)
                return;

            int rows = board.Length;
            int cols = board[0].Length;

            for (int i = 0; i < rows; i++)
            {
                if (board[i][0] == 'O')
                    bfs(board, i, 0);
                if (board[i][cols - 1] == 'O')
                    bfs(board, i, cols - 1);
            }
            for (int j = 0; j < cols; j++)
            {
                if (board[0][j] == 'O')
                    bfs(board, 0, j);
                if (board[rows - 1][j] == 'O')
                    bfs(board, rows - 1, j);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i][j] == 'O')
                        board[i][j] = 'X';
                    if (board[i][j] == '*')
                        board[i][j] = 'O';
                }
            }
        }

        public static void bfs(char[][] board, int i, int j)
        {
            int rows = board.Length;
            int cols = board[0].Length;
            Queue<(int, int)> queue = new Queue<(int, int)>();

            queue.Enqueue((i, j));

            while (queue.Count > 0)
            {
                int row = queue.Peek().Item1;
                int col = queue.Peek().Item2;
                queue.Dequeue();
                board[row][col] = '*';

                if (row - 1 >= 0 && board[row - 1][col] == 'O')
                    queue.Enqueue((row - 1, col));
                if (row + 1 < rows && board[row + 1][col] == 'O')
                    queue.Enqueue((row + 1, col));
                if (col - 1 >= 0 && board[row][col - 1] == 'O')
                    queue.Enqueue((row, col - 1));
                if (col + 1 < cols && board[row][col + 1] == 'O')
                    queue.Enqueue((row, col + 1));
            }
        }
    }
}
