using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class FindPositiveIntegerSolutionForAGivenEquation
	{
		public static IList<IList<int>> FindSolutionBruteForce(CustomFunction customfunction, int z)
		{
			IList<IList<int>> res = new List<IList<int>>();

			for (int i = 1; i <= 1000; i++)
			{
				for (int j = 1; j < 1000; j++)
				{
					if (customfunction.f(i, j) == z)
					{
						List<int> r = new List<int>();
						r.Add(i);
						r.Add(j);
						res.Add(r);
					}
				}
			}
			return res;
		}

		public static IList<IList<int>> FindSolutionBinarySearch(CustomFunction customfunction, int z)
		{
			IList<IList<int>> res = new List<IList<int>>();

			for (int i = 1; i <= z; i++)
			{
				int start = 1;
				int end = 1001;
				int mid = 0;

				while (start <= end)
				{
					mid = start + (end - start) / 2;
					if (customfunction.f(i, mid) < z)
					{
						start = mid + 1;
					}
					else
					{
						end = mid - 1;
					}
				}
				if (customfunction.f(i, start) == z)
				{
					IList<int> l = new List<int>();
					l.Add(i);
					l.Add(start);
					res.Add(l);
				}
			}
			return res;
		}
		public static IList<IList<int>> FindSolution(CustomFunction customfunction, int z)
		{
			int x = 1; int y = 1000;
			IList<IList<int>> res = new List<IList<int>>();

			while (x <= 1000 && y > 0)
			{
				int m = customfunction.f(x, y);
				if (m < z)
				{
					x++;
				}
				else if (m > z)
				{
					y--;
				}
				else
				{
					IList<int> l = new List<int>();
					l.Add(x);
					l.Add(y);
					res.Add(l);
					x++;
					y--;
				}
			}
			return res;
		}
	}
	public class CustomFunction
	{
		public int f(int x, int y)
		{
			return x * y;
		}
	}
}
