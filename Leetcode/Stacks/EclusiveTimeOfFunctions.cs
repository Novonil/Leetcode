using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class EclusiveTimeOfFunctions
	{
        public static int[] ExclusiveTime(int n, IList<string> logs)
        {
            int[] res = new int[n];
            Stack<int> stack = new Stack<int>();

            int prev = 0;

            for (int i = 0; i < logs.Count; i++)
            {
                string[] s = logs[i].Split(":");
                if (s[1].Equals("start"))
                {
                    if (stack.Count > 0)
                        res[stack.Peek()] += Convert.ToInt32(s[2]) - prev;
                    stack.Push(Convert.ToInt32(s[0]));
                    prev = Convert.ToInt32(s[2]);
                }
                else
                {
                    res[stack.Peek()] += Convert.ToInt32(s[2]) - prev + 1;
                    stack.Pop();
                    prev = Convert.ToInt32(s[2]) + 1;
                }
            }
            return res;
        }
    }
}
