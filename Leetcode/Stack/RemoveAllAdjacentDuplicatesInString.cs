using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	class RemoveAllAdjacentDuplicatesInString
	{
		public string RemoveDuplicates(string S)
		{
			StringBuilder result = new StringBuilder();
			Stack<char> s = new Stack<char>();
			Stack<char> reverse = new Stack<char>();
			for (int i = 0; i<S.Length; i++)
			{
				if(s.Count == 0 || s.Peek() != S[i])
				{
					s.Push(S[i]);
				}
				else
				{
					s.Pop();
				}
			}
			foreach(char c in s)
			{
				reverse.Push(c);
			}
			foreach(char c in reverse)
			{
				result.Append(c);
			}
			return result.ToString();
		}
	}
}
