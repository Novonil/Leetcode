using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Binary_Search
{
	class TheKWeakestRowsInAMatrix
	{
		public static int[] KWeakestRowsBruteForce(int[][] mat, int k)
		{
			Dictionary<int, int> rowSoldierMap = new Dictionary<int, int>();

			int m = mat.Length;
			int n = mat[0].Length;
			int counter = 0;
			int i = 0;
			int j = 0;

			int[] res = new int[k];

			for (i = 0; i < m; i++)
			{
				for (j = 0; j < n; j++)
				{
					if (mat[i][j] == 0)
					{
						break;
					}
				}
				rowSoldierMap.Add(i, j);
			}

			foreach (KeyValuePair<int, int> kv in rowSoldierMap.OrderBy(x => x.Value).ThenBy(x => x.Key))
			{
				if (counter < k)
				{
					res[counter++] = kv.Key;
				}
				else
				{
					break;
				}
			}
			return res;
		}
		public static int[] KWeakestRowsBinarySearch(int[][] mat, int k)
		{
			int m = mat.Length;
			int n = mat[0].Length;
			int counter = 0;
			Dictionary<int, int> rowSoldierMap = new Dictionary<int, int>();

			int[] res = new int[k];

			for (int i = 0; i < m; i++)
			{
				int start = 0;
				int end = n - 1;
				int mid;
				int firstZero;
				while (start <= end)
				{
					mid = start + (end - start) / 2;

					if (mat[i][mid] == 0)
					{
						firstZero = mid;
						end = mid - 1;
					}
					else
					{
						start = mid + 1;
					}
				}
				rowSoldierMap.Add(i, start);
			}
			foreach (KeyValuePair<int, int> kv in rowSoldierMap.OrderBy(x => x.Value).ThenBy(x => x.Key))
			{
				if (counter < k)
				{
					res[counter++] = kv.Key;
				}
				else
				{
					break;
				}
			}
			return res;
		}
		public static int[] KWeakestRows(int[][] mat, int k)
		{
			int m = mat.Length;
			int n = mat[0].Length;
			int counter = 0;
			int rows = 0;

			HashSet<int> res = new HashSet<int>();

			for(int j = 0; j<n; j++)
			{
				for(int i = 0; i<m;i++)
				{
					if(mat[i][j] == 0 && (j-1 < 0 || mat[i][j-1] == 1))
					{
						res.Add(i);
						counter++;
						if(counter == k)
						{
							return res.ToArray<int>();
						}
					}
				}
			}
			while (counter < k && rows < m)
			{
				if(!res.Contains(rows))
				{
					res.Add(rows);
					counter++;
				}
				rows++;
			}

			return res.ToArray<int>();
		}
	}
}
