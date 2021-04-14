using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class BasicCalculatorIII
	{
        public int Calculate(string s)
        {
            int len = s.Length;
            Stack<char> operators = new Stack<char>();
            Stack<int> operands = new Stack<int>();


            for (int i = 0; i < len; i++)
            {
                char c = s[i];

                if (c == '(')
                {
                    operators.Push('(');
                }
                else if (c == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        evaluateSubExpression(operators, operands);
                    }
                    operators.Pop();
                }
                else if (isOperator(c))
                {
                    while (operators.Count > 0 && precedence(operators.Peek()) >= precedence(c))
                    {
                        evaluateSubExpression(operators, operands);
                    }
                    operators.Push(c);
                }
                else
                {
                    int number = 0;
                    while (i < len && Char.IsDigit(s[i]))
                    {
                        number = number * 10 + (s[i] - '0');
                        i++;
                    }
                    i--;
                    operands.Push(number);
                }
            }

            while (operators.Count > 0)
            {
                evaluateSubExpression(operators, operands);
            }
            return operands.Peek();
        }

        public bool isOperator(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/')
                return true;
            return false;
        }

        public int precedence(char op)
        {
            switch (op)
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

        public void evaluateSubExpression(Stack<char> operators, Stack<int> operands)
        {
            char op = extractOperator(operators);
            int op2 = extractOperand(operands);
            int op1 = extractOperand(operands);
            operands.Push(performOperation(op, op1, op2));
        }

        public int extractOperand(Stack<int> operands)
        {
            int operand = operands.Peek();
            operands.Pop();
            return operand;
        }
        public char extractOperator(Stack<char> operators)
        {
            char operatorr = operators.Peek();
            operators.Pop();
            return operatorr;
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
                    if (op2 == 0) throw new DivideByZeroException();
                    double val = (int)(double)op1 / (double)op2;
                    return val > 0 ? (int)Math.Floor(val) : (int)Math.Ceiling(val);
            }
            return 0;
        }
    }
}
