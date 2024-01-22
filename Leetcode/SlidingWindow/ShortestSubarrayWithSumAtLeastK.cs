using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class ShortestSubarrayWithSumAtLeastK
	{
        public int ShortestSubarray(int[] nums, int k)
        {
            int len = nums.Length;
            int[] prefix = new int[len];
            List<int> list = new List<int>();

            prefix[0] = nums[0];

            int ans = -1;


            for (int i = 1; i < len; i++)
                prefix[i] = prefix[i - 1] + nums[i];

            for (int i = 0; i < len; i++)
            {
                if (prefix[i] >= k)
                {
                    if (ans == -1)
                        ans = i + 1;
                    else
                        ans = Math.Min(ans, i + 1);
                }

                int ySum = prefix[i];
                int xSum = ySum - k;

                while (list.Count > 0 && prefix[list[0]] <= xSum)
                {
                    if (ans == -1)
                        ans = i - list[0];
                    else
                        ans = Math.Min(ans, i - list[0]);

                    list.RemoveAt(0);
                }

                while (list.Count > 0 && prefix[list[list.Count - 1]] >= prefix[i])
                {
                    list.RemoveAt(list.Count - 1);
                }

                list.Add(i);
            }
            return ans;
        }
    }
}
