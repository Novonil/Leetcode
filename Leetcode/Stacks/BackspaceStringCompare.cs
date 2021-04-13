using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class BackspaceStringCompare
	{
        public bool BackspaceCompare(string s, string t)
        {
            BackspaceStringCompare ob = new BackspaceStringCompare();

            string s1 = ob.editedString(s);
            string t1 = ob.editedString(t);
            if (s1.Equals(t1))
                return true;
            return false;
        }

        public string editedString(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }

            if (stack.Count == 0)
                return "";

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
