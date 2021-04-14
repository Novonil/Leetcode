using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class BasicCalculatorI
	{
        public int Calculate(string s)
        {
            s = "(" + s + ")";
            int len = s.Length;
            Stack<int> operands = new Stack<int>();
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < len; i++)
            {
                char c = s[i];
                if (c == ' ')
                {
                    continue;
                }
                else if (c == '(')
                {
                    operators.Push('(');
                    if (s[i + 1] == '-')
                    {
                        i++;
                        int number = 0;
                        while (i < len && Char.IsDigit(s[i]))
                        {
                            number = number * 10 + (s[i] - '0');
                            i++;
                        }
                        i--;
                        operands.Push(-1 * number);
                    }
                    else if (s[i + 1] == '+')
                    {
                        i++;
                        continue;
                    }
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
                else if (Char.IsDigit(c))
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

        public void evaluateSubExpression(Stack<char> operators, Stack<int> operands)
        {
            char op = extractOperator(operators);
            int op2 = extractOperand(operands);
            int op1 = extractOperand(operands);
            operands.Push(performOperation(op, op1, op2));
        }

        public bool isOperator(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/')
                return true;
            return false;
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

        public char extractOperator(Stack<char> operators)
        {
            char operatorr = operators.Peek();
            operators.Pop();
            return operatorr;
        }

        public int extractOperand(Stack<int> operands)
        {
            int operand = operands.Peek();
            operands.Pop();
            return operand;
        }

        public int performOperation(char c, int op1, int op2)
        {
            switch (c)
            {
                case '+':
                    return op1 + op2;
                case '-':
                    return op1 - op2;
                case '*':
                    return op1 * op2;
                case '/':
                    if (op2 == 0) throw new DivideByZeroException();
                    return op1 / op2;
            }
            return 0;
        }
    }
}
