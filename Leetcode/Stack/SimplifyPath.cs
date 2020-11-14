	using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	public class SimplifyPath
	{
		public static string SimplifyPaths(string path)
		{
			StringBuilder canonicalPath = new StringBuilder();
			string[] commands = path.Split('/',StringSplitOptions.RemoveEmptyEntries);
			Stack<string> folder = new Stack<string>();
			for(int i = 0; i < commands.Length; i++)
			{
				if(commands[i] == ".")
				{
					continue;
				}
				else if(commands[i] == "..")
				{
					if (folder.Count > 0)
					{
						folder.Pop();
					}
				}
				else
				{
					folder.Push(commands[i]);
				}
			}
			if (folder.Count == 0)
				return "/";

			string[] result = new string[folder.Count];
			int k = folder.Count;
			foreach (string s in folder)
			{
				result[--k] = s;
			}
			foreach(string s in result)
			{
				canonicalPath.Append("/" + s);
			}
			return String.IsNullOrEmpty(canonicalPath.ToString()) ? "/" : canonicalPath.ToString();
		}
	}
}
