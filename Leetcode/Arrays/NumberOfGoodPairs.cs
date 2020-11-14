using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class NumberOfGoodPairs
	{
		public int NumIdenticalPairs(int[] nums)
		{
			int count = 0;
			int[] countMap = new int[100];
			foreach(int i in nums)
			{
				countMap[i - 1]++;
			}
			foreach(int i in countMap)
			{
				if(i>1)
				{
					count += i * (i - 1) / 2;
				}
			}
			return count;
		}
	}
}
