using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class MaximumScoreFromRemovingStones
	{
		public static int MaximumScore(int a, int b, int c)
		{
			List<int> nums = new List<int>();

			nums.Add(a);
			nums.Add(b);
			nums.Add(c);

			nums.Sort();

			int low = nums[0];
			int mid = nums[1];
			int high = nums[2];

			if(low + mid <= high)
			{
				return low + mid;
			}
			else
			{
				return (low + mid + high) / 2;
			}
		}
		public static int MaximumScoreHeap(int a, int b, int c)
		{
			PriorityQueue<int> maxHeap = new PriorityQueue<int>(3, Comparer<int>.Create((a, b) => { return b.CompareTo(a); }));
			maxHeap.Add(a);
			maxHeap.Add(b);
			maxHeap.Add(c);
			int score = 0;
			while(true)
			{
				int f = maxHeap.Peek();
				maxHeap.Poll();
				int s = maxHeap.Peek();
				maxHeap.Poll();
				
				if (f == 0 || s == 0)
					break;

				score++;
				f--;
				s--;
				maxHeap.Add(f);
				maxHeap.Add(s);
			}
			return score;

		}
	}
}
