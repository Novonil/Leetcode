using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class NUniqueIntegersSumUptoZero
	{
		public int[] SumZero(int n)
		{
			int x = n / 2;
			int y = -1 * x;
			int[] arr = new int[n];
			int index = 0;
			while(x >= y)
			{
				if (x == 0 && n % 2 != 0)
					arr[index++] = 0;
				else if(x != 0)
					arr[index++] = x;
				x--;
			}

			return arr;
		}
	}
}
