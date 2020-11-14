using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode
{
	class SimplifyPath
	{
		public string SimplifyPaths(string path)
		{
			StringBuilder result = new StringBuilder();
			Stack<string> s = new Stack<string>();
			string[] instructions = path.Split("/", StringSplitOptions.RemoveEmptyEntries);

			foreach(string str in instructions)
			{
				if(str.Equals(".."))
				{
					if(s.Count > 0)
					{
						s.Pop();
					}
				}
				else if(str.Equals("."))
				{
					continue;
				}
				else
				{
					s.Push(str);
				}
			}
			int l = s.Count;
			if (l == 0)
				return "/";

			string[] res = new string[l];

			foreach(string str in s)
			{
				res[--l] = str;
			}
			foreach (string st in res)
				result.Append("/" + st);

			return result.ToString();
		}
	}
}
