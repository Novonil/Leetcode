using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class CapacityToShipPackagesWithinDDays
	{
		public static int ShipWithinDays(int[] weights, int D)
		{
			int start = 1;
			int end = int.MaxValue;
			int mid = -1;
			int minimumCapacity = 0;

			while(start<=end)
			{
				mid = start + (end - start) / 2;

				if(CanShip(weights, D, mid))
				{
					minimumCapacity = mid;
					end = mid - 1;
				}
				else
				{
					start = mid + 1;
				}
			}
			return minimumCapacity;
		}
		public static bool CanShip(int[] weights, int D, int capacity)
		{
			int countOfDays = 1;
			int currentSum = 0;

			for(int i = 0; i<weights.Length; i++)
			{
				if (weights[i] > capacity)
					return false;
				if(currentSum + weights[i] <= capacity)
				{
					currentSum += weights[i];
				}
				else
				{
					countOfDays++;
					currentSum = weights[i];
				}
				if (countOfDays > D)
					return false;
			}
			return true;
		}
	}
}
