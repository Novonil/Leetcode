using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
    class OnlineStockSpan
    {
        List<int> prices;
        Stack<int> stack;
        public OnlineStockSpan()
        {
            prices = new List<int>();
            stack = new Stack<int>();
        }

        public int Next(int price)
        {
            prices.Add(price);
            while (stack.Count > 0 && prices[stack.Peek()] <= price)
            {
                stack.Pop();
            }
            int index = stack.Count == 0 ? -1 : stack.Peek();
            stack.Push(prices.Count - 1);
            return prices.Count - 1 - index;
        }
    }
}
