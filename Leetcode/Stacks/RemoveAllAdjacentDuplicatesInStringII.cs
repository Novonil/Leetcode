using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Stacks
{
    class RemoveAllAdjacentDuplicatesInStringII
    {
        public static string RemoveDuplicates(string s, int k)
        {
            Stack<(char, int)> stack = new Stack<(char, int)>();


            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (stack.Count > 0 && stack.Peek().Item1 == c)
                {
                    int freq = stack.Peek().Item2 + 1;

                    stack.Pop();

                    if (freq != k)
                    {
                        stack.Push((c, freq));
                    }
                }
                else
                {
                    stack.Push((c, 1));
                }
            }
            int resultLength = stack.Sum(x => x.Item2);
            char[] result = new char[resultLength];
            while (stack.Count > 0)
            {
                var popped = stack.Peek();
                result[--resultLength] = popped.Item1;
                popped.Item2 -= 1;
                stack.Pop();
                if (popped.Item2 > 0)
                {
                    stack.Push(popped);
                }

            }
            return new String(result);
        }

        public static string RemoveDuplicateDromString(string s, int k)
        {
            Stack<int> stack = new Stack<int>();
            char[] ch = s.ToCharArray();
            int j = 0;
            for (int i = 0; i < ch.Length; i++, j++)
            {
                ch[j] = ch[i];
                if (j == 0 || ch[j - 1] != ch[j])
                {
                    stack.Push(1);
                }
                else
                {
                    int freq = stack.Peek() + 1;
                    stack.Pop();
                    if (freq == k)
                    {
                        j = j - k;
                    }
                    else
                    {
                        stack.Push(freq);
                    }
                }
            }
            return new String(ch, 0, j);
        }
    }
}
