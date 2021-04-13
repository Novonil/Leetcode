using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class MinStack
	{
        //Stack<int> stack;
        Stack<long> stack;
        Stack<int> supportingStack;
        long min;
        /** initialize your data structure here. */
        public MinStack()
        {
            //stack =  new Stack<int>();
            stack = new Stack<long>();
            supportingStack = new Stack<int>();
        }

        public void Push(int val)
        {
            /*stack.Push(val);
            if(supportingStack.Count == 0 || (supportingStack.Count > 0 && val <= supportingStack.Peek()))
            {
                supportingStack.Push(val);
            }*/

            if (stack.Count == 0)
            {
                stack.Push((long)val);
                min = val;
            }
            else
            {
                if (val < min)
                {
                    stack.Push((long)2 * (long)val - (long)min);
                    min = val;
                }
                else
                {
                    stack.Push((long)val);
                }
            }

        }

        public void Pop()
        {
            if (stack.Count == 0)
                return;
            long popped = stack.Peek();
            stack.Pop();

            if (popped <= min)
            {
                min = (long)2 * (long)min - popped;
            }
            /*if(supportingStack.Peek() == popped)
            {
                supportingStack.Pop();
            }*/
        }

        public int Top()
        {
            if (stack.Count == 0)
                return -1;
            if(stack.Peek() < min)
			{
                return (int)min;
			}
            return (int)stack.Peek();
        }

        public int GetMin()
        {
            if (stack.Count == 0)
                return -1;

            return (int)min;
            //return supportingStack.Peek();
        }
    }
}
