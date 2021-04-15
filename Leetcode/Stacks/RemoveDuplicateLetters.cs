using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class RemoveDuplicateLetters
	{
        public string RemoveDuplicateLetter(string s)
        {
            Stack<char> stack = new Stack<char>();
            HashSet<char> seen = new HashSet<char>();
            Dictionary<int, int> lastOccurence = new Dictionary<int, int>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (lastOccurence.ContainsKey(c))
                {
                    lastOccurence[c] = i;
                }
                else
                {
                    lastOccurence.Add(c, i);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (!seen.Contains(c))
                {
                    while (stack.Count > 0 && stack.Peek() > c && lastOccurence[stack.Peek()] > i)
                    {
                        seen.Remove(stack.Peek());
                        stack.Pop();
                    }
                    stack.Push(c);
                    seen.Add(c);
                }
            }
            char[] result = new char[stack.Count];
            while (stack.Count > 0)
            {
                result[stack.Count - 1] = stack.Peek();
                stack.Pop();
            }
            return new String(result);
        }
    }
}
