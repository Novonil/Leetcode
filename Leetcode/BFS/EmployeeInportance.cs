using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.BFS
{
	class EmployeeInportance
	{
        public class Employee
        {
            public int id;
            public int importance;
            public IList<int> subordinates;
        }
        public int GetImportance(IList<Employee> employees, int id)
        {
            Dictionary<int, (int, IList<int>)> empLookup = new Dictionary<int, (int, IList<int>)>();
            foreach (Employee employee in employees)
            {
                if (!empLookup.ContainsKey(employee.id))
                {
                    empLookup.Add(employee.id, (employee.importance, employee.subordinates));
                }
            }
            return bfs(empLookup, id);
        }

        public int bfs(Dictionary<int, (int, IList<int>)> empLookup, int id)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(id);
            int totalImportance = 0;
            while (queue.Count > 0)
            {
                int empId = queue.Dequeue();
                IList<int> subordinates;
                if (empLookup.ContainsKey(empId))
                {
                    totalImportance += empLookup[empId].Item1;
                    subordinates = empLookup[empId].Item2;
                    foreach (int subordinate in subordinates)
                    {
                        queue.Enqueue(subordinate);
                    }
                }
            }
            return totalImportance;
        }
    }
}
