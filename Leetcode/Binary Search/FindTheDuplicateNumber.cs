using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class FindTheDuplicateNumber
	{
		public static int FindDuplicateBruteForce(int[] nums)
		{
			HashSet<int> numbersVisited = new HashSet<int>();

			foreach(int i in nums)
			{
				if (numbersVisited.Contains(i))
					return i;
				numbersVisited.Add(i);
			}
			return -1;
		}
		public static int FindDuplicate(int[] nums)
		{
		}
}
