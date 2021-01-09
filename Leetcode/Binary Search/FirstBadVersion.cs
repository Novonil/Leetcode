using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class FirstBadVersion
	{
		public int FirstBadVersions(int n)
		{
			int start = 1;
			int end = n;
			int mid;
			int firstBadVersion = -1;

			while(start <= end)
			{
				mid = start + (end - start) / 2;
				if(IsBadVersion(mid))
				{
					firstBadVersion = mid;
					end = mid - 1;
				}
				else
				{
					start = mid + 1;
				}
			}
			return firstBadVersion;
		}
		public static bool IsBadVersion(int x)
		{
			if (x > 5)
				return true;
			return false;
		}
	}
}
