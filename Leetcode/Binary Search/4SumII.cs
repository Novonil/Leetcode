	using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class _4SumII
	{
		public static int FourSumCountBruteForce(int[] A, int[] B, int[] C, int[] D)
		{
			int count = 0;
			foreach(int i in A)
			{
				foreach(int j in B)
				{
					foreach(int k in C)
					{
						foreach(int l in D)
						{
							if (i + j + k + l == 0)
							{
								count++;
							}
						}
					}
				}
			}
			return count;
		}
		public static int FourSumCountBruteForceOptimizedCubedN(int[] A, int[] B, int[] C, int[] D)
		{
			int count = 0;
			Dictionary<int, int> freqMap = new Dictionary<int, int>();
			
			foreach(int i in C)
			{
				foreach (int j in D)
				{
					if (freqMap.ContainsKey(i + j))
					{
						freqMap[i]++;
					}
					else
					{
						freqMap.Add(i+j, 1);
					}
				}
			}

			foreach (int i in A)
			{
				foreach (int j in B)
				{
					if(freqMap.ContainsKey(-1 * (i + j)))
					{
						count += freqMap[-1 * (i + j)];
					}
				}
			}
			return count;
		}
	}
}
