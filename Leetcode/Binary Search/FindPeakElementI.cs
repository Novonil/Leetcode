using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class FindPeakElementI
	{
        public int FindPeakElement(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            int len = nums.Length;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                int prev = (mid - 1);
                int next = (mid + 1);

                if (prev < 0 || next >= len)
                {
                    if (prev < 0 && next >= len)
                        return mid;
                    else if (prev < 0)
                    {
                        if (nums[mid] > nums[next])
                            return mid;
                        else
                            start = next;
                    }
                    else
                    {
                        if (nums[mid] > nums[prev])
                            return mid;
                        else
                            end = prev;
                    }
                }
                else
                {
                    if (nums[prev] < nums[mid] && nums[mid] > nums[next])
                        return mid;
                    else if (nums[prev] > nums[mid])
                    {
                        end = prev;
                    }
                    else
                    {
                        start = next;
                    }
                }
            }
            return -1;
        }
        public int FindPeakElements(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start < end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] > nums[mid + 1])
                    end = mid;
                else
                    start = mid + 1;
            }
            return start;
        }
    }
}
