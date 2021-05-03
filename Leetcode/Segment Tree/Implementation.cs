using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Segment_Tree
{
	class Implementation
	{
		public static void buildSegmentTreeFromArray(int[] arr, int[] segmentTree, int start, int end, int pos)
		{
			if (start == end)
			{
				segmentTree[pos] = arr[start];
				return;
			}

			int left = 2 * pos + 1;
			int right = 2 * pos + 2;
			int mid = start + (end - start) / 2;
			buildSegmentTreeFromArray(arr, segmentTree, start, mid, left);
			buildSegmentTreeFromArray(arr, segmentTree, mid + 1, end, right);

			segmentTree[pos] = Math.Min(segmentTree[left], segmentTree[right]);			
		}

		public static int minInRange(int[] segmentTree, int qStart, int qEnd, int start, int end, int pos)
		{
			if(start >= qStart && end <= qEnd)
				return segmentTree[pos];
			
			if(start > qEnd || end < qStart)
				return int.MaxValue;

			int mid = start + (end - start) / 2;
			int left = 2 * pos + 1;
			int right = 2 * pos + 2;
			return Math.Min(minInRange(segmentTree, qStart, qEnd, start, mid, left), minInRange(segmentTree, qStart, qEnd, mid + 1, end, right));
		}
	}
}

/*

1 2 4 0

2 * 4 - 1= 7

start	end	pos	mid	left	right
0		3	0	1	1		2
0		1	1	0	3		4
0		0	3	
1		1	4	
2		3	2	2	5		6
2		2	5	
3		3	6	
0	1	2	3	4	5	6
0	1	0	1	2	4	0


 
 */
