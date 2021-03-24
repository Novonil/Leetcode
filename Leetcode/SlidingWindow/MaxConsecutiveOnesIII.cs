using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class MaxConsecutiveOnesIII
	{
        public static int LongestOnes(int[] A, int K)
        {
            int size = A.Length;
            int left = 0;
            int right = 0;

            while (right < size)
            {
                if (A[right] == 0)
                {
                    K--;
                }
                if (K < 0)
                {
                    if (A[left] == 0)
                        K++;

                    left++;
                }
                right++;
            }

            return right - left;
        }
    }
}
