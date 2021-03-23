using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class DietPlanPerformance
	{
        public static int DietPlanPerformances(int[] calories, int k, int lower, int upper)
        {
            int size = calories.Length;
            int left = 0;
            int right = 0;
            int sum = 0;
            int points = 0;

            while (right < size)
            {
                sum += calories[right];

                if (right - left + 1 == k)
                {
                    if (sum > upper)
                        points++;
                    else if (sum < lower)
                        points--;

                    sum -= calories[left];
                    left++;
                }
                right++;
            }
            return points;
        }
    }
}
