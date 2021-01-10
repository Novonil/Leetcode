using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class ArrangingCoins
	{
		public static int ArrangeCoins(int n)
		{
			if (n < 2)
				return n;

			if(n==3)
				return 2;
			
			long start = 0;
			long end = n / 2;
			long mid;
			long lastSize = -1;

			while(start<= end)
			{
				mid = start + (end - start) / 2;

				if(mid+1 <= 2 * n / mid)
				{
					lastSize = mid;
					start = mid + 1;
				}
				else
				{
					end = mid - 1;
				}
			}
			return (int) lastSize;
		}
	}
}
