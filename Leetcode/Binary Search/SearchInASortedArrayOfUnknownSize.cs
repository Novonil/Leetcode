using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class SearchInASortedArrayOfUnknownSize
	{
		public int Search(int[] reader, int target)
		{
			int start = 0;
			int end = 1;
			int mid;

			while(reader[end] <= target)
			{
				if(reader[end] == Int32.MaxValue)
				{
					break;
				}
				start = end + 1;
				end = end * 2;
			}

			while(start<=end)
			{
				mid = start + ((end - start) / 2);

				if(reader[mid] == target)
				{
					return mid;
				}
				else if(reader[mid] < target)
				{
					start = mid + 1;
				}
				else
				{
					end = mid - 1;
				}
			}

			return -1;
		}
	}
}
