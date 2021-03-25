using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class GrumpyBookStoreOwner
	{
        public static int MaxSatisfied(int[] customers, int[] grumpy, int X)
        {
            int size = customers.Length;
            int left = 0;
            int right = 0;
            int maxUnhappyCustomers = 0;
            int happyCustomers = 0;
            int unhappyCustomers = 0;

            while (right < size)
            {
                if (grumpy[right] == 0)
                {
                    happyCustomers += customers[right];
                }
                else
                {
                    unhappyCustomers += customers[right];
                }
                if (right - left + 1 == X)
                {
                    maxUnhappyCustomers = Math.Max(maxUnhappyCustomers, unhappyCustomers);
                    if(grumpy[left] == 1)
					{
                        unhappyCustomers -= customers[left];
                    }
                    left++;
                }
                right++;
            }
            return happyCustomers + maxUnhappyCustomers;
        }
    }
}
