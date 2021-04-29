using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.DFS
{
	class EmployeeImportance
	{
        public class Employee
        {
            public int id;
            public int importance;
            public IList<int> subordinates;
        }

        public static int GetImportance(IList<Employee> employees, int id)
        {
            if (employees == null || employees.Count == 0)
                return 0;
            return dfs(employees, id);
        }

        public static int dfs(IList<Employee> employees, int id)
        {
            int totalImportance = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].id == id)
                {
                    totalImportance += employees[i].importance;

                    for (int j = 0; j < employees[i].subordinates.Count; j++)
                    {
                        totalImportance += dfs(employees, employees[i].subordinates[j]);
                    }
                }
            }
            return totalImportance;
        }

        public static int GetImportanceOptimized(IList<Employee> employees, int id)
        {
            if (employees == null || employees.Count == 0)
                return 0;

            Dictionary<int, Employee> empLookup = new Dictionary<int, Employee>();

            foreach (Employee employee in employees)
            {
                if (!empLookup.ContainsKey(employee.id))
                    empLookup.Add(employee.id, employee);
            }
            return dfsOptimized(empLookup, id);
        }

        public static int dfsOptimized(Dictionary<int, Employee> empLookup, int id)
        {
            int totalImportance = empLookup[id].importance;
            for (int i = 0; i < empLookup[id].subordinates.Count; i++)
            {
                totalImportance += dfsOptimized(empLookup, empLookup[id].subordinates[i]);
            }
            return totalImportance;
        }
    }
}
