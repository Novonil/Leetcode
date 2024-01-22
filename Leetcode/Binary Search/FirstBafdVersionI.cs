using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class FirstBafdVersionI
	{
        public int FirstBadVersion(int n)
        {
            int start = 1;
            int end = n;
            int ans = 0;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (IsBadVersion(mid))
                {
                    ans = mid;
                    end = mid - 1;
                }
                else
                    start = mid + 1;
            }
            return ans;
        }

        public bool IsBadVersion(int number)
		{
            if (number > 10)
                return false;
            return true;
		}
    }
}
