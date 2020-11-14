using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class CountNumberOfTeams
	{
		//public int NumTeams(int[] rating)
		//{
		//	Dictionary<int, int> mapsGreater = new Dictionary<int, int>();
		//	Dictionary<int, int> mapsSmaller = new Dictionary<int, int>();

		//	for (int i = 0; i< rating.Length; i++)
		//	{
		//		int greaterCount = 1, smallerCount = 1;
		//		for(int j = i+1; j<rating.Length; j++)
		//		{
		//			if(rating[i] > rating[j])
		//			{
		//				mapsSmaller.Add(rating[i], smallerCount++);
		//			}
		//			else
		//			{
		//				mapsGreater.Add(rating[i], greaterCount++);
		//			}
		//		}
		//	}

		//	foreach(KeyValuePair<int, int> kv in mapsSmaller)
		//	{

		//	}

		//}
		public int NumTeamsBF(int[] rating)
		{
			int count = 0;
			for (int i = 0; i < rating.Length; i++)
			{
				for (int j = i + 1; j < rating.Length; j++)
				{
					for (int k = j + 1; k < rating.Length; k++)
					{
						if ((rating[i] < rating[j] && rating[j] < rating[k]) || (rating[i] > rating[j] && rating[j] > rating[k]))
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
