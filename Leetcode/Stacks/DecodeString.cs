using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Stacks
{
	class DecodeString
	{
		public static string DecodeStrings(string s)
		{
            Stack<string> stack = new Stack<string>();
            Stack<int> repeat = new Stack<int>();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == ']')
                {
                    StringBuilder word = new StringBuilder();
                    while (stack.Count > 0 && stack.Peek() != "[")
                    {
                        word.Insert(0, stack.Peek());
                        stack.Pop();
                    }
                    stack.Pop();
                    int freq = repeat.Peek();
                    repeat.Pop();
                    stack.Push(String.Concat(Enumerable.Repeat(word, freq)));
                }
                else if (Char.IsDigit(c))
                {
                    int num = 0;
                    while (i < s.Length && Char.IsDigit(s[i]))
                    {
                        num = num * 10 + (s[i] - '0');
                        i++;
                    }
                    i--;
                    repeat.Push(num);
                }
                else
                {
                    stack.Push(c.ToString());
                }
            }

            while (stack.Count >= 1)
            {
                result.Insert(0, stack.Peek());
                stack.Pop();
            }
            return result.ToString();
        }
	}
}
