using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	class ValidParenthesis
	{
		public static bool IsValid(string s)
		{
			char c;
			Stack<char> stck = new Stack<char>();
			for(int i = 0; i< s.Length; i++)
			{
				if(s[i] == '(' || s[i] == '{' || s[i] == '[')
				{
					stck.Push(s[i]);
				}
				else
				{
					if (stck.Count == 0)
						return false;
					c = stck.Pop();
					if ((c == '(' && s[i] == ')') || (c == '{' && s[i] == '}') || (c == '[' && s[i] == ']'))
						continue;
					return false;
				}
			}
			return stck.Count == 0;
		}
	}
}
