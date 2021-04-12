using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class BaseballGame
	{
        public int CalPoints(string[] ops)
        {
            Stack<string> stack = new Stack<string>();
            int sum = 0;
            BaseballGame ob = new BaseballGame();
            foreach (string op in ops)
            {
                if (op.Equals("+"))
                {
                    ob.calculateSum(stack);
                }
                else if (op.ToUpper().Equals("D"))
                {
                    ob.calculateDouble(stack);
                }
                else if (op.ToUpper().Equals("C"))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(op);
                }
            }

            sum = ob.calculateScore(stack);
            return sum;
        }

        public void calculateSum(Stack<string> stack)
        {
            if (stack.Count >= 2)
            {
                long op2 = Convert.ToInt64(stack.Peek());
                stack.Pop();
                long op1 = Convert.ToInt64(stack.Peek());
                stack.Push(op2.ToString());
                long res = op1 + op2;
                stack.Push(res.ToString());
            }
        }

        public void calculateDouble(Stack<string> stack)
        {
            if (stack.Count > 0)
            {
                long num = Convert.ToInt64(stack.Peek());
                long res = num * 2;
                stack.Push(res.ToString());
            }
        }

        public int calculateScore(Stack<string> stack)
        {
            long sum = 0;
            while (stack.Count > 0)
            {
                sum += Convert.ToInt64(stack.Peek());
                stack.Pop();
            }
            return Convert.ToInt32(sum);
        }
    }
}
