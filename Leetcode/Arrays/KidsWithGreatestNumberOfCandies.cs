using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class KidsWithGreatestNumberOfCandies
	{
		public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
		{
			int max = int.MinValue;
			IList<bool> result = new List<bool>();
			foreach(int i in candies)
			{
				if (i > max)
					max = i;
			}
			for(int i = 0; i<candies.Length; i++)
			{
				if(candies[i] + extraCandies >= max)
				{
					result.Add(true);
				}
				else
				{
					result.Add(false);
				}
			}
			return result;
		}
	}
}
