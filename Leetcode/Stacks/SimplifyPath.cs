using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class SimplifyPath
	{
        public string SimplifyPath(string path)
        {
            string[] splitPath = path.Split("/", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < splitPath.Length; i++)
            {
                if (splitPath[i] == ".")
                {
                    continue;
                }
                else if (splitPath[i] == "..")
                {
                    if (stack.Count == 0)
                        continue;
                    stack.Pop();
                }
                else
                {
                    stack.Push(splitPath[i]);
                }
            }

            if (stack.Count == 0)
                return "/";

            string[] canPath = new string[stack.Count];
            int k = stack.Count - 1;
            while (stack.Count > 0)
            {
                canPath[k--] = stack.Peek();
                stack.Pop();
            }
            return "/" + String.Join("/", canPath);
        }
    }
}
