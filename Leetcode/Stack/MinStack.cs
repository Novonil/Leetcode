using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	public class MinStack
    {
		Stack<int> s = new Stack<int>();
		Stack<int> ss = new Stack<int>();
		/** initialize your data structure here. */
		public MinStack()
		{

		}

		public void Push(int x)
		{
			if (s.Count == 0 || ss.Peek() >= x)
			{
				ss.Push(x);
			}
			s.Push(x);
		}

		public void Pop()
		{
			if (s.Peek() == ss.Peek())
				ss.Pop();
			s.Pop();
		}

		public int Top()
		{
			return s.Peek();
		}

		public int GetMin()
		{
			return ss.Peek();
		}
		/** initialize your data structure here. */

		//int min = int.MinValue;
  //      Stack<int> s = new Stack<int>();

  //      public MinStack()
		//{

		//}

		//public void Push(int x)
		//{
  //          if (s.Count == 0)
		//	{
  //              min = x;
  //              s.Push(x);
  //          }
  //          else
		//	{
  //              if(x < min)
		//		{
  //                  s.Push(2 * x - min);
  //                  min = x;
		//		}
  //              else
		//		{
  //                  s.Push(x);
		//		}
		//	}
		//}

		//public void Pop()
		//{
		//	if(s.Peek() < min)
		//	{
  //              min = (2 * min) - s.Peek();
		//	}
  //          s.Pop();
		//}

		//public int Top()
		//{
  //          if (s.Peek() < min)
  //          {
  //              return min;
  //          }
  //          else
		//	{
  //              return s.Peek();
  //          }
            
		//}

		//public int GetMin()
		//{
  //          return min;
		//}

	}
}
