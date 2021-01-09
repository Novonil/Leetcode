using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class ValidPerfectSquare
	{
		public bool IsPerfectSquare(int num)
		{
			if (num < 2)
				return true;

			int start = 1;
			int end = num / 2;
			int mid;

			while(start <= end)
			{
				mid = start + (end - start) / 2;
				long prod = (long) mid * mid;
				if (prod == num)
					return true;
				else if(prod < num)
				{
					start = mid + 1;
				}
				else
				{
					end = mid - 1;
				}
			}
			return false;
		}
		public bool IsPerfectSquareNewton(int num)
		{
			if (num < 2)
				return true;

			long x = num / 2;
			while (x * x > num)
			{
				x = (x + num / x) / 2;
			}
			return (x * x == num);
		}
	}
}
