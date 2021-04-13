using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class MakeTheStringGood
	{
        public static string MakeGood(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count > 0 && stack.Peek().ToString().ToLower() == s[i].ToString().ToLower() && stack.Peek() != s[i])
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            char[] result = new char[stack.Count];

            while (stack.Count > 0)
            {
                result[stack.Count - 1] = stack.Peek();
                stack.Pop();
            }
            return String.Concat(result);
            //return new String(result);
            //return String.Join("",result);
        }
    }
}
