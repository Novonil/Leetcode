using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.DFS
{
	class TimeNeededToInformAllEmployees
	{
        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            Dictionary<int, List<int>> managerMap = new Dictionary<int, List<int>>();

            for (int i = 0; i < n; i++)
            {
                int key = manager[i];
                if (!managerMap.ContainsKey(key))
                {
                    managerMap.Add(key, new List<int>());
                }
                managerMap[key].Add(i);
            }
            return dfs(managerMap, informTime, headID);
        }

        public int dfs(Dictionary<int, List<int>> managerMap, int[] informTime, int headID)
        {
            int max = 0;
            if (!managerMap.ContainsKey(headID))
                return max;

            for (int i = 0; i < managerMap[headID].Count; i++)
            {
                max = Math.Max(max, dfs(managerMap, informTime, managerMap[headID][i]));
            }
            return max + informTime[headID];
        }
    }
}
