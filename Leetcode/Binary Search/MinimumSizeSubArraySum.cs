using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class MinimumSizeSubArraySum
	{
        public int MinSubArrayLenss(int target, int[] nums)
        {
            int ans = int.MaxValue;
            int len = nums.Length;

            for (int left = 0; left < len; left++)
            {
                int sum = 0;
                for (int right = left; right < len; right++)
                {
                    sum += nums[right];

                    if (sum >= target)
                    {
                        ans = Math.Min(right - left + 1, ans);
                        break;
                    }
                }
            }
            return ans == int.MaxValue ? 0 : ans;
        }
        public int MinSubArrayLens(int target, int[] nums)
        {
            int result = int.MaxValue;
            for (int i = 1; i <= nums.Length; i++)
            {
                for (int j = 0; j <= nums.Length - i; j++)
                {
                    int sum = 0;
                    for (int k = j; k < j + i && k < nums.Length; k++)
                    {
                        sum += nums[k];
                    }
                    if (sum >= target)
                        result = Math.Min(result, i);
                }
            }
            return result == int.MaxValue ? 0 : result;
        }
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0;
            int right = 0;
            int len = nums.Length - 1;
            int minSize = int.MaxValue;
            int sum = 0;

            while (right <= len)
            {
                sum += nums[right];

                if (sum >= target)
                {
                    while (left <= len && sum >= target)
                    {
                        minSize = Math.Min(minSize, right - left + 1);
                        sum -= nums[left];
                        left++;

                    }
                }
                right++;
            }
            return minSize == int.MaxValue ? 0 : minSize;
        }

        public int MinSubArrayLene(int target, int[] nums)
        {
            int ans = 0;
            int len = nums.Length;
            int[] prefix = new int[len];
            List<int> deque = new List<int>();

            prefix[0] = nums[0];

            for (int i = 1; i < len; i++)
                prefix[i] = prefix[i - 1] + nums[i];

            for (int i = 0; i < len; i++)
            {
                if (prefix[i] >= target)
                {
                    if (ans == 0)
                        ans = i + 1;
                    else
                        ans = Math.Min(ans, i + 1);
                }

                int ySum = prefix[i];
                int xSum = prefix[i] - target;

                while (deque.Count > 0 && prefix[deque[0]] <= xSum)
                {
                    if (ans == 0)
                        ans = i - deque[0];
                    else
                        ans = Math.Min(ans, i - deque[0]);

                    deque.RemoveAt(0);
                }

                while (deque.Count > 0 && prefix[deque[deque.Count - 1]] >= prefix[i])
                {
                    deque.RemoveAt(deque.Count - 1);
                }

                deque.Add(i);
            }
            return ans;
        }
    }
}
