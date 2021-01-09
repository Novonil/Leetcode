using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class PeakIndexInAMountainArray
	{
		public static int PeakIndexInMountainArray(int[] arr)
		{
			int n = arr.Length;
			int start = 0;
			int end = arr.Length - 1;
			int mid;
			int prev;
			int next;
			
			while(start <= end)
			{
				mid = start + ((end - start) / 2);
				prev = (mid + n - 1) % n;
				next = (mid + 1) % n;

				if (arr[mid] > arr[prev] && arr[mid] > arr[next])
				{
					return mid;
				}
				else if (arr[mid] < arr[next])
				{
					start = mid + 1;
				}
				else if (arr[prev] > arr[mid])
				{
					end = mid - 1;
				}
			}
			return -1;
		}

		public static int PeakIndexInMountainArrayBruteForce(int[] arr)
		{
			int i = 0;
			while(i + 1 < arr.Length && arr[i] < arr[i+1])
			{
				i++;
			}
			return i;
		}
	}
}
