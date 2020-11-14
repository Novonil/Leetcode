using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class SearchInRotatedArrayII
	{
		public bool Search(int[] nums, int target)
		{
			foreach(int i in nums)
			{
				if (i == target)
					return true;
			}
			return false;
		}
	}
}
