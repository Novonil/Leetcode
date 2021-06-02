using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class DungeonGame
	{
        public int CalculateMinimumHP(int[][] dungeon)
        {
            int rows = dungeon.Length;
            int cols = dungeon[0].Length;

            int[][] dp = new int[rows][];

            for (int i = 0; i < rows; i++)
                dp[i] = new int[cols];

            foreach (int[] arr in dp)
            {
                Array.Fill(arr, int.MaxValue);
            }

            calculateMinimumHealth(dungeon, dp, rows, cols);

            return dp[0][0];
        }

        public void calculateMinimumHealth(int[][] dungeon, int[][] dp, int rows, int cols)
        {
            int rightHealth, downHealth, nextHealth, minHealth, currentHealth;

            for (int row = rows - 1; row >= 0; row--)
            {
                for (int col = cols - 1; col >= 0; col--)
                {
                    currentHealth = dungeon[row][col];
                    rightHealth = calculateHealth(dp, row, col + 1, rows, cols, currentHealth);
                    downHealth = calculateHealth(dp, row + 1, col, rows, cols, currentHealth);
                    nextHealth = Math.Min(rightHealth, downHealth);

                    if (nextHealth == int.MaxValue)
                        minHealth = currentHealth >= 0 ? 1 : 1 - currentHealth;
                    else
                        minHealth = nextHealth;

                    dp[row][col] = minHealth;
                }
            }
        }

        public int calculateHealth(int[][] dp, int row, int col, int rows, int cols, int currentHealth)
        {
            if (row >= rows || col >= cols)
                return int.MaxValue;

            int nextHealth = dp[row][col];

            return Math.Max(nextHealth - currentHealth, 1);

        }
    }
}
