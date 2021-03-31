using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class FurthestBuildingYouCanReach
	{
		public static int FurthestBuilding(int[] heights, int bricks, int ladders)
		{
			PriorityQueue<int> minHeap = new PriorityQueue<int>();

			for(int i = 0; i < heights.Length - 1; i++)
			{
				int difference = heights[i + 1] - heights[i];
				if (difference <= 0)
					continue;
				minHeap.Add(difference);
				if(minHeap.Size > ladders)
				{
					bricks -= minHeap.Peek();
					minHeap.Poll();
					if (bricks < 0)
						return i;
				}
			}
			return heights.Length - 1;
		}

		public static int FurthestBuildingBricks(int[] heights, int bricks, int ladders)
		{
			PriorityQueue<int> maxHeap = new PriorityQueue<int>(heights.Length, Comparer<int>.Create((a, b) => { return b.CompareTo(a); })); 

			for(int i = 0; i<heights.Length - 1; i++)
			{
				int difference = heights[i + 1] - heights[i];

				if (difference <= 0)
					continue;

				maxHeap.Add(difference);
				bricks -= difference;

				if(bricks < 0)
				{
					bricks += maxHeap.Peek();
					ladders--;
					maxHeap.Poll();
					if(ladders < 0)
					{
						return i;
					}
				}
			}
			return heights.Length - 1;
		}
	}
}
