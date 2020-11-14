using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class FindNumberWithEvenNumberOfDigits
	{
		public int FindNumbers(int[] nums)
		{
			int count = 0;
			foreach (int i in nums)
			{
				if(i.ToString().Length % 2 == 0)
				{
					count++;
				}
			}
			return count;
		}
	}
}
