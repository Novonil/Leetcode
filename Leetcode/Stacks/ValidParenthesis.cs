using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class ValidParenthesis
	{
        public static bool IsValid(string s)
        {
            if (s.Length == 0)
                return true;

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (openingBrackets(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    if (c == ')' && stack.Peek() != '(')
                        return false;

                    else if (c == '}' && stack.Peek() != '{')
                        return false;

                    else if (c == ']' && stack.Peek() != '[')
                        return false;
                    stack.Pop();
                }
            }
            if (stack.Count > 0)
                return false;
            return true;
        }

        public static bool openingBrackets(char c)
        {
            if (c == '(' || c == '{' || c == '[')
                return true;
            return false;
        }
    }
}

