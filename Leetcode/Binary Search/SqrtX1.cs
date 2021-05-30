using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class SqrtX1
	{
        public int MySqrt(int x)
        {
            int start = 1;
            int end = x;
            int res = 0;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if ((long)mid * mid == x)
                    return mid;
                else if ((long)mid * mid < x)
                {
                    res = mid;
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return res;
        }
    }
}
