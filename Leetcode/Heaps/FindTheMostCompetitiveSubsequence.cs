using System;
using System.Collections.Generic;
using System.Text;
using NetTopologySuite.Utilities;

namespace Leetcode.Heaps
{
	class FindTheMostCompetitiveSubsequence
	{
		public static int[] mostCompetitive(int[] nums, int k)
		{
			int availableDelete = nums.Length - k;
			int[] result = new int[k];
			List<int> deque = new List<int>();
			
			for(int i = 0; i < nums.Length; i++)
			{
				while(deque.Count > 0 && deque[deque.Count - 1] > nums[i] && availableDelete > 0)
				{
					deque.RemoveAt(deque.Count - 1);
					availableDelete--;
				}
				deque.Add(nums[i]);
			}

			for(int i = 0; i< k; i++)
			{
				result[i] = deque[i];
			}
			return result;
		}
	}
}
