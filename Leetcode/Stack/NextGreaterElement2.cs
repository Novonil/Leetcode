using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	class NextGreaterElement2
	{
		public static int[] NextGreaterElements(int[] nums)
		{
			int n = nums.Length;
			int[] result = new int[n];

			Stack<int> s = new Stack<int>();

			for(int i = 2*n -1; i >= 0; i--)
			{
				while(s.Count > 0 && s.Peek() <= nums[i%n])
				{
					s.Pop();
				}
				if(s.Count == 0)
				{
					result[i%n] = -1;
				}
				else
				{
					result[i%n] = s.Peek();
				}
				s.Push(nums[i%n]);
			}
			
			return result;
		}
	}
}
