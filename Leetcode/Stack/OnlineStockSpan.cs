using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	class OnlineStockSpan
	{
        List<int> arr = new List<int>();

        public int Next(int price)
        {
            arr.Add(price);
            Stack<(int, int)> s = new Stack<(int, int)>();
            
            for(int i = arr.Count - 1; i>=0; i--)
			{
                if(arr[i] > price)
				{
                    return arr.Count - i;
				}
			}
            return arr.Count;
        }
    }
}
