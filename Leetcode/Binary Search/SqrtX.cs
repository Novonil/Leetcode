using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class SqrtX
	{
		public static int MySqrt(int x)
		{
			if (x < 2)
				return x;

			int start = 2;
			int end = x/2;
			int mid = start +((end - start) / 2); ;
			long square;

			while (start<=end)
			{
				mid = start + ((end - start) / 2);
				square = (long) mid * mid;
				if(square == x)
				{
					return mid;
				}
				else if(square < x)
				{
					start = mid + 1;
				}
				else
				{
					end = mid - 1;
				}
			}
			return end;
		}
		public static int MySqrtBruteForce(int x)
		{
			long result = 0;
			for (long i = 0; i <= x; i++)
			{
				long square = i * i;
				if (square <= int.MaxValue && square <= x)
					result = i;
				else
				{
					break;
				}
			}
			return Convert.ToInt32(result);
		}
		public static int MySqrtCheat(int x)
		{
			if (x < 2)
				return x;
			int left = (int) Math.Pow(Math.E, (Math.Log(x) / 2));
			int right = left + 1;
			return (long)right * right > x ? left: right;
		}
		public static int MySqrtRecursion(int x)
		{
			if (x < 2)
				return x;
			int left = MySqrtRecursion(x >> 4) << 1;
			int right = left + 1;
			return (long)right * right <= x ? right : left;
		}
		public static int MySqrtNewton(int x)
		{
			if (x < 2)
				return x;
			double x0 = x;
			double x1 = 0.5 * (x0 + (x / x0));
			while(Math.Abs(x0 - x1) >= 1)
			{
				x0 = x1;
				x1 = 0.5 * (x0 + (x / x0));
			}
			return (int) x1;
		}
	}
}
