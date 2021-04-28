using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Stacks
{
	class DecodeStrings
	{
        public static string DecodeString(string s)
        {
            int len = s.Length;
            Stack<int> freq = new Stack<int>();
            Stack<string> stack = new Stack<string>();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    int number = 0;
                    while (Char.IsDigit(s[i]))
                    {
                        number = number * 10 + (s[i] - '0');
                        i++;
                    }
                    freq.Push(number);
                    i--;
                }
                else if (s[i] == ']')
                {
                    StringBuilder str = new StringBuilder();

                    while (stack.Count > 0 && !stack.Peek().Equals("["))
                    {
                        str.Insert(0, stack.Peek());
                        stack.Pop();
                    }
                    stack.Pop();
                    if (freq.Count > 0)
                    {
                        int fr = freq.Pop();
                        stack.Push(String.Concat(Enumerable.Repeat(str.ToString(), fr)));
                    }
                }
                else
                {
                    stack.Push(s[i].ToString());
                }
            }
            while (stack.Count > 0)
            {
                result.Insert(0, stack.Peek());
                stack.Pop();
            }
            return result.ToString();
        }
    }
}
