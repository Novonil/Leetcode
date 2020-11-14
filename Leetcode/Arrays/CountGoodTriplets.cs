using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class CountGoodTriplets
	{
		public int CountOfGoodTriplets(int[] arr, int a, int b, int c)
		{
			int count = 0;
			for (int i = 0; i<arr.Length - 2; i++)
			{
				for(int j = i+1; j<arr.Length -1; j++)
				{
					for(int k = j+1; k<arr.Length; k++)
					{
						if((Math.Abs(arr[i] - arr[j]) <= a) && (Math.Abs(arr[j] - arr[k]) <= b) && (Math.Abs(arr[i] - arr[k]) <= c))
						{
							count++;
						}
					}
				}
			}
			return count;
		}
	}
}
