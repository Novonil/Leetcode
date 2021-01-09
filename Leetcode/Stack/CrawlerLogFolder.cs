using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	class CrawlerLogFolder
	{
		public static int minOperations(String[] logs)
		{
			Stack<string> st = new Stack<string>();
			foreach(string s in logs)
			{
				if (s.Equals("./"))
				{
					continue;
				}
				else if (s.Equals("../"))
				{
					if(st.Count > 0)
					{
						st.Pop();
					}
					
				}
				else
				{
					st.Push(s);
				}
			}
			return st.Count;
		}
	}
}
