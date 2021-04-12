using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stacks
{
    class NextGreaterElementI
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            int[] result = new int[nums1.Length];
            int[] nextGreater = new int[nums2.Length];

            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                map.Add(nums2[i], i);
                while (stack.Count > 0 && stack.Peek() <= nums2[i])
                {
                    stack.Pop();
                }
                nextGreater[i] = stack.Count > 0 ? stack.Peek() : -1;
                stack.Push(nums2[i]);
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                result[i] = nextGreater[map[nums1[i]]];
            }
            return result;
        }

        public static int[] res(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length];


            Dictionary<int, int> map = findNextGreater(nums2);

            for (int i = 0; i < nums1.Length; i++)
            {
                result[i] = map[nums1[i]];
            }
            return result;
        }

        public static Dictionary<int, int> findNextGreater(int[] nums2)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek() <= nums2[i])
                {
                    stack.Pop();
                }
                map.Add(nums2[i], stack.Count == 0 ? -1 : stack.Peek());
                stack.Push(nums2[i]);
            }
            return map;
        }
    }
}
