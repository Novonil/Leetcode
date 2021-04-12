using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class BuildAnArrayWithStackOperations
	{
		public static IList<string> buildArray(int[] target, int n)
		{
			IList<string> result = new List<string>();
			int i = 0;
			int j = 1;

			while(i < target.Length)
			{
				result.Add("Push");
				if(target[i] == j)
				{
					i++;
				}
				else
				{
					result.Add("Pop");
				}
				j++;
			}
			return result;
		}
	}
}
