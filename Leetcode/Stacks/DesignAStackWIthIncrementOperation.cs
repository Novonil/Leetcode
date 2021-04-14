using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class DesignAStackWIthIncrementOperation
	{
        int max;
        Stack<int> stack;
        Stack<int> supportingStack;
        public DesignAStackWIthIncrementOperation(int maxSize)
        {
            max = maxSize;
            stack = new Stack<int>(maxSize);
            supportingStack = new Stack<int>();
        }

        public void Push(int x)
        {
            if (stack.Count < max)
            {
                stack.Push(x);
            }

        }

        public int Pop()
        {
            if (stack.Count > 0)
                return stack.Pop();
            return -1;
        }

        public void Increment(int k, int val)
        {
            while (stack.Count > 0)
            {
                int value = stack.Peek();
                if (stack.Count <= k)
                {
                    value += val;
                }
                supportingStack.Push(value);
                stack.Pop();
            }

            while (supportingStack.Count > 0)
            {
                stack.Push(supportingStack.Peek());
                supportingStack.Pop();
            }
        }
    }
}
