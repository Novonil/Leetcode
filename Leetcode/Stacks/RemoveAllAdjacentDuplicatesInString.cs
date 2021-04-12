using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class RemoveAllAdjacentDuplicatesInString
	{
		public static string removeDuplicates(string S)
		{
			if (S.Length <= 1)
				return S;

			Stack<char> stack = new Stack<char>();
			foreach(char c in S)
			{
				if(stack.Count > 0 && stack.Peek() == c)
				{
					stack.Pop();
				}
				else
				{
					stack.Push(c);
				}
			}
			char[] result = new char[stack.Count];
			int i = stack.Count - 1;
			while(stack.Count > 0)
			{
				result[i--] = stack.Peek();
				stack.Pop();
			}
			return new string(result);
		}
	}
}
