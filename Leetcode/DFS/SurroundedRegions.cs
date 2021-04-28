using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.DFS
{
	class SurroundedRegions
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
                    dfs(board, i, 0);
                if (board[i][cols - 1] == 'O')
                    dfs(board, i, cols - 1);
            }

            for (int j = 0; j < cols; j++)
            {
                if (board[0][j] == 'O')
                    dfs(board, 0, j);
                if (board[rows - 1][j] == 'O')
                    dfs(board, rows - 1, j);
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

        public static void dfs(char[][] board, int i, int j)
        {
            if (!isValid(board, i, j) || board[i][j] != 'O')
                return;

            board[i][j] = '*';

            dfs(board, i - 1, j);
            dfs(board, i + 1, j);
            dfs(board, i, j - 1);
            dfs(board, i, j + 1);

        }

        public static bool isValid(char[][] board, int i, int j)
        {
            if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length)
                return false;
            return true;
        }
    }
}
