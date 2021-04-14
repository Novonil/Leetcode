using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
	class ValidateStackSequences
	{
        public static bool ValidateStackSequence(int[] pushed, int[] popped)
        {
            Stack<int> stack = new Stack<int>();
            int j = 0;
            for (int i = 0; i < pushed.Length; i++)
            {
                stack.Push(pushed[i]);
                while (stack.Count > 0 && j < popped.Length && stack.Peek() == popped[j])
                {
                    stack.Pop();
                    j++;
                }
            }
            if (j != popped.Length)
            {
                return false;
            }
            return true;
        }
    }
}
