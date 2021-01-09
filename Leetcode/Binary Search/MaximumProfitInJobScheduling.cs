using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class MaximumProfitInJobScheduling
	{
		public static int JobScheduling(int[] startTime, int[] endTime, int[] profit)
		{
			return MaxProfit(startTime, endTime, profit, profit.Length);
		}
		public static int MaxProfit(int[] startTime, int[] endTime, int[] profit, int n)
		{
			if(n==0)
			{
				return 0;
			}
			return 0;
		}
	}
}
