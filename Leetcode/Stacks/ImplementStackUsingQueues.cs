using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class ImplementStackUsingQueues
	{
        int top;
        Queue<int> q1;
        Queue<int> q2;
        /** Initialize your data structure here. */
        public ImplementStackUsingQueues()
        {
            q1 = new Queue<int>();
            q2 = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            q1.Enqueue(x);
            top = x;
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            int popped;
            while (q1.Count > 1)
            {
                top = q1.Dequeue();
                q2.Enqueue(top);
            }
            if (q1.Count == 0)
            {
                return -1;
            }
            popped = q1.Dequeue();
            Queue<int> temp = q2;
            q2 = q1;
            q1 = temp;
            return popped;
        }

        /** Get the top element. */
        public int Top()
        {
            if (q1.Count == 0)
                return -1;
            return top;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            if (q1.Count == 0)
                return true;
            return false;
        }


    }
    public class MyStack
	{
        int top;
        Queue<int> q1;
        Queue<int> q2;

        /** Initialize your data structure here. */
        public MyStack()
        {
            q1 = new Queue<int>();
            q2 = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            q2.Enqueue(x);
            top = x;
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }
            Queue<int> temp = q2;
            q2 = q1;
            q1 = temp;
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            int popped = 0;
            if (q1.Count > 0)
            {
                popped = q1.Dequeue();
            }
            if (q1.Count > 0)
                top = q1.Peek();
            return popped;
        }

        /** Get the top element. */
        public int Top()
        {
            if (q1.Count == 0)
                return -1;
            return top;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            if (q1.Count == 0)
            {
                return true;
            }
            return false;
        }
    }

    public class MyStackUpdated
	{
        int top;
        Queue<int> q1;
        /** Initialize your data structure here. */
        public MyStackUpdated()
        {
            q1 = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            top = x;
            q1.Enqueue(x);
            int stackLength = q1.Count;
            while (stackLength > 1)
            {
                q1.Enqueue(q1.Dequeue());
                stackLength--;
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            if (q1.Count == 0)
                return -1;

            int popped = q1.Dequeue();
            if (q1.Count > 0)
                top = q1.Peek();
            return popped;
        }

        /** Get the top element. */
        public int Top()
        {
            if (q1.Count == 0)
                return -1;
            return top;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            if (q1.Count == 0)
                return true;
            return false;
        }
    }
}
