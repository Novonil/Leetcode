using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	class NextGreaterElement1
	{
		public static int[] NextGreaterElement(int[] nums1, int[] nums2)
		{
			int n = nums2.Length;
			int[] result = new int[nums1.Length];
			Dictionary<int,int> nearestGreaterToRight = new Dictionary<int, int>();
			Stack<int> s = new Stack<int>();

			for(int i = n-1; i>=0; i--)
			{
				while(s.Count > 0 && s.Peek() <= nums2[i])
				{
					s.Pop();
				}
				if(s.Count == 0)
				{
					nearestGreaterToRight.Add(nums2[i],-1);
				}
				else
				{
					nearestGreaterToRight.Add(nums2[i],s.Peek());
				}
				s.Push(nums2[i]);
			}

			for(int i = 0; i < nums1.Length; i++)
			{
				result[i] = nearestGreaterToRight[nums1[i]];
			}
			return result;

		}
	}
}
