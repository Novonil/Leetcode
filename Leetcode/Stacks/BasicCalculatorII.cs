using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class BasicCalculatorII
	{
        public int Calculate(string s)
        {
            Stack<char> stack = new Stack<char>();
            Stack<int> values = new Stack<int>();

            //string[] expression = s.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            int len = s.Length;

            for (int i = 0; i < len; i++)
            {
                char c = s[i];
                if (isOperator(c))
                {
                    while (stack.Count > 0 && precedence(stack.Peek()) >= precedence(c))
                    {
                        char op = extractOperator(stack);
                        int op2 = extractOperand(values);
                        int op1 = extractOperand(values);
                        values.Push(performOperation(op, op1, op2));
                    }
                    stack.Push(c);
                }
                else if (Char.IsDigit(c))
                {
                    int number = 0;
                    while (i < len && Char.IsDigit(s[i]))
                    {
                        number = (number * 10) + (s[i] - '0');
                        i++;
                    }
                    i--;
                    values.Push(number);
                }
            }
            while (stack.Count > 0)
            {
                char op = extractOperator(stack);
                int op2 = extractOperand(values);
                int op1 = extractOperand(values);
                values.Push(performOperation(op, op1, op2));
            }

            return values.Peek();
        }

        public char extractOperator(Stack<char> stck)
        {
            char operators = stck.Peek();
            stck.Pop();
            return operators;
        }
        public int extractOperand(Stack<int> val)
        {
            int operand = val.Peek();
            val.Pop();
            return operand;
        }

        public bool isOperator(char ch)
        {
            if (ch.Equals('+') || ch.Equals('-') || ch.Equals('*') || ch.Equals('/'))
                return true;
            return false;
        }

        public int performOperation(char op, int op1, int op2)
        {
            switch (op)
            {
                case '+':
                    return op1 + op2;
                case '-':
                    return op1 - op2;
                case '*':
                    return op1 * op2;
                case '/':
                    if (op2 == 0)
                        throw new DivideByZeroException();
                    return (int)Math.Floor((double)op1 / (double)op2);
            }
            return 0;
        }

        public int precedence(char c)
        {
            switch (c)
            {
                case '+':
                    return 1;
                case '-':
                    return 1;
                case '*':
                    return 2;
                case '/':
                    return 2;
            }
            return -1;
        }
    }
}
