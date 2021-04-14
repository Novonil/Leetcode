﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class DailyTemperatures
	{
        public int[] DailyTemperature(int[] T)
        {

            int len = T.Length;
            Stack<int> stack = new Stack<int>();
            int[] result = new int[len];
            for (int i = len - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && T[stack.Peek()] <= T[i])
                    stack.Pop();
                result[i] = stack.Count == 0 ? 0 : stack.Peek() - i;
                stack.Push(i);
            }

            return result;
        }
    }
}
