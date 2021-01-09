using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class IntersectionOfTwoArrays
	{
		public static int[] Intersection(int[] nums1, int[] nums2)
		{
			HashSet<int> hs = new HashSet<int>();
			HashSet<int> result = new HashSet<int>();
			foreach(int i in nums1)
			{
				hs.Add(i);
			}
			foreach(int i in nums2)
			{
				if(hs.Contains(i))
				{
					result.Add(i);
				}
			}
			int[] res = new int[result.Count];
			result.CopyTo(res);
			return res;
		}
	}
}
