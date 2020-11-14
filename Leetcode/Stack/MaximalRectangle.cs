using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Stack
{
	class MaximalRectangle
	{
		public static int MaximalAreaRectangle(char[][] matrix)
		{
			if (matrix.Length == 0)
				return 0;
			int max = int.MinValue;
			int cols = matrix[0].Length;
			int[] sum = new int[cols];

			foreach (char[] i in matrix)
			{
				
				for (int j = 0; j < cols; j++)
				{
					if(i[j] == '0')
					{
						sum[j] = 0;
					}
					else
					{
						sum[j] += 1;
					}
				}
				max = Math.Max(max, MaxAreaOfHistogram(sum));
			}
			return max;
		}
		public static int MaxAreaOfHistogram(int[] arr)
		{
			int max = int.MinValue;
			int n = arr.Length;

			int[] maxToLeft = new int[n];
			int[] maxToRight = new int[n];

			Stack<(int, int)> maxLeft = new Stack<(int, int)>();
			Stack<(int, int)> maxRight = new Stack<(int, int)>();

			for(int i = 0; i<n; i++)
			{
				while(maxLeft.Count > 0 && maxLeft.Peek().Item1 >= arr[i])
				{
					maxLeft.Pop();
				}
				if(maxLeft.Count == 0)
				{
					maxToLeft[i] = -1;
				}
				else
				{
					maxToLeft[i] = maxLeft.Peek().Item2;
				}
				maxLeft.Push((arr[i], i));
			}

			for(int i = n-1; i >=0; i--)
			{
				while(maxRight.Count > 0 && maxRight.Peek().Item1 >= arr[i])
				{
					maxRight.Pop();
				}
				if(maxRight.Count == 0)
				{
					maxToRight[i] = n;
				}
				else
				{
					maxToRight[i] = maxRight.Peek().Item2;
				}
				maxRight.Push((arr[i], i));
			}

			for(int i = 0; i<n; i++)
			{
				max = Math.Max(max, ((maxToRight[i] - maxToLeft[i] - 1) * arr[i]));
			}
			return max;
		}
	}
}
