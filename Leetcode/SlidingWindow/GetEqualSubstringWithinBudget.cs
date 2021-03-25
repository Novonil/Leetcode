using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class GetEqualSubstringWithinBudget
	{
        public static int EqualSubstring(string s, string t, int maxCost)
        {
            int size = s.Length;
            int left = 0;
            int right = 0;
            int maxSubstringLength = 0;

            while (right < size)
            {
                if (s[right] != t[right])
                {
                    if (maxCost - Math.Abs((int)(s[right] - t[right])) < 0)
                    {
                        while (maxCost - Math.Abs((int)(s[right] - t[right])) < 0)
                        {
                            maxCost += Math.Abs((int)(s[left] - t[left]));
                            left++;
                        }
                    }
                    maxCost -= Math.Abs((int)(s[right] - t[right]));
                }
                maxSubstringLength = Math.Max(maxSubstringLength, right - left + 1);
                right++;
            }

            return maxSubstringLength;
        }
    }
}
