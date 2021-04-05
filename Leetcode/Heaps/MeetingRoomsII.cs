using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class MeetingRoomsII
	{
		public static int MinMeetingRooms(int[][] intervals)
		{
			int minRooms = 0;

			int[] start = new int[intervals.Length];
			int[] end = new int[intervals.Length];

			for(int i = 0; i < intervals.Length; i++)
			{
				start[i] = intervals[i][0];
				end[i] = intervals[i][1];
			}

			Array.Sort(start);
			Array.Sort(end);

			int strt_Index = 0;
			int end_Index = 0;

			while(strt_Index < start.Length)
			{
				if(start[strt_Index] >= end[end_Index])
				{
					minRooms--;
					end_Index++;
				}
				minRooms++;
				strt_Index++;
			}

			return minRooms;
		}

		public static int minRoomsHeaps(int[][] intervals)
		{
			PriorityQueue<int> minHeap = new PriorityQueue<int>();
			Array.Sort(intervals, Comparer<int[]>.Create((a, b) => { return a[0].CompareTo(b[0]); }));

			minHeap.Add(intervals[0][1]);

			for(int i = 1; i<intervals.Length; i++)
			{
				if(minHeap.Peek() <= intervals[i][0])
				{
					minHeap.Poll();
				}
				minHeap.Add(intervals[i][1]);
			}
			return minHeap.Size;
		}
	}
}
