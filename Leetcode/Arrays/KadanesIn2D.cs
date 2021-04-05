using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class KadanesIn2D
	{
		public class KadaneResult
		{
			public int top;
			public int bottom;
			public int maxSum;

			public KadaneResult(int top, int bottom, int maxSum)
			{
				this.top = top;
				this.bottom = bottom;
				this.maxSum = maxSum;
			}
		}
		public class Result
		{
			public int top;
			public int bottom;
			public int left;
			public int right;
			public int maxSum;
			public override string ToString()
			{
				return "Result [maxSum = " + maxSum + ", leftBount = " + left + 
						", rightBound = " + right + ", upperBound = " + top + 
						", lowerBound = " + bottom + "]";
			}
		}
		

		public static Result maxSumRectangle(int[,] arr)
		{
			int row = arr.GetLength(0);
			int col = arr.GetLength(1);

			Result res = new Result();

			for (int left = 0; left < col; left ++)
			{
				int[] temp = new int[row];
				
				for (int right = left; right < col; right++)
				{
					for(int i = 0; i < row; i++)
					{
						temp[i] += arr[i, right];
					}
					KadaneResult kd = kadane(temp);
					if(res.maxSum < kd.maxSum)
					{
						res.maxSum = kd.maxSum;
						res.top = kd.top;
						res.bottom = kd.bottom;
						res.left = left;
						res.right = right;
					}
				}
			}
			return res;
		}

		public static KadaneResult kadane(int[] arr)
		{
			int max_Sum = arr[0];
			int curr_Sum = arr[0];
			int curr_Top = 0;
			int top = 0;
			int bottom = 0;

			for(int i = 1; i < arr.Length; i++)
			{
				if(curr_Sum >= 0)
				{
					curr_Sum += arr[i];
				}
				else 
				{
					curr_Sum = arr[i];
					curr_Top = i;
				}
				if(max_Sum < curr_Sum)
				{
					max_Sum = curr_Sum;
					top = curr_Top;
					bottom = i;
				}
			}

			KadaneResult kd = new KadaneResult(top, bottom, max_Sum);
			return kd;
		}
	}
}
