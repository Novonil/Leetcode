using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class MinimumAddToMakeParenthesisValid
	{
        public int MinAddToMakeValid(string S)
        {

            int count = 0;
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    stack.Push('(');
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        count++;
                        continue;
                    }
                    stack.Pop();
                }
            }
            return count + stack.Count;
        }

        public int min(string S)
		{
            int count = 0;
            int balance = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    balance++;
                }
                else
                {
                    balance--;
                }
                if (balance == -1)
                {
                    count++;
                    balance++;
                }

            }
            return count + balance;
        }
    }
}
