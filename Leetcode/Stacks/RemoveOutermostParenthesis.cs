using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class RemoveOutermostParenthesis
	{
		public static string removeOuterParenthesis(string S)
		{
			if (S.Length == 0)
				return "";

			Stack<char> stack = new Stack<char>();
			StringBuilder result = new StringBuilder();

			foreach(char c in S)
			{
				if(c == '(')
				{
					if(stack.Count > 0)
					{
						result.Append("(");
					}
					stack.Push('(');
				}
				else
				{
					stack.Pop();
					if(stack.Count > 0)
					{
						result.Append(")");
					}
				}
			}
			return result.ToString();
		}

		public static string removeOuterParenthesisConstantSpace(string S)
		{
			if(S.Length == 0)
			{
				return "";
			}

			int open = 0;
			StringBuilder result = new StringBuilder();

			foreach(char c in S)
			{
				if(c == '(')
				{
					if(open > 0)
					{
						result.Append("(");
					}
					open++;
				}
				else
				{
					open--;
					if(open > 0)
					{
						result.Append(")");
					}
				}
			}
			return result.ToString();
		}
	}
}
