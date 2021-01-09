using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class GuessNumberHigherOrLower
	{
		public static int GuessNumber(int n)
		{
			int start = 0;
			int end = n;
			int mid;
			while(start<=end)
			{
				mid = start + (end - start) / 2;

				if(GuessNumber(mid) == 0)
				{
					return mid;
				}
				else if(GuessNumber(mid) < 0)
				{
					end = mid - 1;
				}
				else
				{
					start = mid + 1;
				}
			}
			return -1;
		}
	}
}
