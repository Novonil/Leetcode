using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	class MinimumInsertionsToBalanceAParenthesisString
	{
		public static int MinInsertions(string s)
		{
			int min = 0;
			Stack<char> stck = new Stack<char>();

			for(int i = 0; i < s.Length; i++)
			{
				if(s[i] == '(')
				{
					stck.Push(s[i]);
				}
				else
				{
					if(stck.Count == 0)
					{
						if(s[i+1] == ')')
						{
							i++;
						}
						else
						{
							min++;
						}
					}
					else
					{
						if(s[i+1] == ')')
						{
							i++;
						}
						else
						{
							min++;
							stck.Pop();
						}
					}
				}
			}
			min += stck.Count * 2;
			return min;
		}
	}
}
