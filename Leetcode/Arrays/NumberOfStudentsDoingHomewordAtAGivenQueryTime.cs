using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class NumberOfStudentsDoingHomewordAtAGivenQueryTime
	{
		public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
		{
			int count = 0;
			for(int i = 0; i< startTime.Length; i++)
			{
				if (queryTime >= startTime[i] && queryTime <= endTime[i])
					count++;
			}
			return count;
		}
	}
}
