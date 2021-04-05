using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	class FindTheMostCompetitiveSubsequence
	{
		public static int[] mostCompetitive(int[] nums, int k)
		{
			Stack<int> stck = new Stack<int>();


			for(int i = 0; i < nums.Length; i++)
			{
				while(stck.Count > 0 && stck.Peek() > nums[i] && stck.Count + nums.Length - i > k)
				{
					stck.Pop();
				}
				if(stck.Count < k)
				{
					stck.Push(nums[i]);
				}
			}
			int[] result = new int[k];
			int j = k - 1;
			while(stck.Count > 0)
			{
				result[j--] = stck.Peek();
				stck.Pop();
			}
			return result;
		}
	}
}
