using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class EvaluateReversePolishNotation
	{
        public int EvalRPN(string[] tokens)
        {

            if (tokens.Length == 0)
                return 0;
            Stack<int> operands = new Stack<int>();

            foreach (string token in tokens)
            {
                if (isOperator(token))
                {
                    int op2 = Convert.ToInt32(operands.Peek());
                    operands.Pop();
                    int op1 = Convert.ToInt32(operands.Peek());
                    operands.Pop();
                    operands.Push(performOperation(token, op1, op2));
                }
                else
                {
                    operands.Push(Convert.ToInt32(token));
                }
            }
            return operands.Peek();
        }

        public bool isOperator(string str)
        {
            if (str.Equals("+") || str.Equals("-") || str.Equals("*") || str.Equals("/"))
                return true;
            return false;
        }

        public int performOperation(string op, int op1, int op2)
        {
            switch (op)
            {
                case "+":
                    return (op1 + op2);
                case "-":
                    return (op1 - op2);
                case "*":
                    return (op1 * op2);
                case "/":
                    double res = (double)op1 / (double)op2;
                    return res >= 0 ? (int)Math.Floor(res) : (int)Math.Ceiling(res);
            }
            return 0;

        }
    }
}
