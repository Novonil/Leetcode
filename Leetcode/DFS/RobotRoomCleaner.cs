using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.DFS
{
    interface Robot
    {
        // Returns true if the cell in front is open and robot moves into the cell.
        // Returns false if the cell in front is blocked and robot stays in the current cell.
        public bool Move();

        // Robot will stay in the same cell after calling turnLeft/turnRight.
        // Each turn will be 90 degrees.
        public void TurnLeft();
        public void TurnRight();

        // Clean the current cell.
        public void Clean();
    }
    class RobotRoomCleaner
	{
        Robot robot;
        HashSet<(int, int)> visited = new HashSet<(int, int)>();
        int[][] directions;

        public void CleanRoom(Robot robot)
        {
            directions = new int[4][];
            directions[0] = new int[] { -1, 0 };
            directions[1] = new int[] { 0, 1 };
            directions[2] = new int[] { 1, 0 };
            directions[3] = new int[] { 0, -1 };

            this.robot = robot;
            dfs(0, 0, 0);
        }

        public void dfs(int row, int col, int direction)
        {
            visited.Add((row, col));
            robot.Clean();

            for (int i = 0; i < 4; i++)
            {
                int newDir = (direction + i) % 4;
                int newRow = row + directions[newDir][0];
                int newCol = col + directions[newDir][1];
                if (!visited.Contains((newRow, newCol)) && robot.Move())
                {
                    dfs(newRow, newCol, newDir);
                    goBack();
                }
                robot.TurnRight();
            }
        }
        public void goBack()
        {
            robot.TurnRight();
            robot.TurnRight();
            robot.Move();
            robot.TurnRight();
            robot.TurnRight();
        }
    }
}
