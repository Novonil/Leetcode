using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class SpiralMatrixIII
	{
        public static int[][] SpiralMatrixesIII()
        {

            int rows = 5;
            int cols = 6;
            int rStart = 1;
            int cStart = 4;

            int[][] result = new int[(rows * cols)][];

            int left = cStart;
            int right = cStart;
            int top = rStart;
            int bottom = rStart;

            int count = 0;
            int size = rows * cols;


            while (count < size)
            {
                for (int i = left; i <= right && count < size; i++)
                {
                    if (top >= 0 && i < cols && i >= 0)
                        result[count++] = new int[] { top, i };
                }
                right++;

                for (int i = top; i <= bottom && count < size; i++)
                {
                    if (i < rows && i >= 0 && right < cols)
                        result[count++] = new int[] { i, right };
                }
                bottom++;

                for (int i = right; i >= left && count < size; i--)
                {
                    if (i >= 0 && i < cols && bottom < rows)
                        result[count++] = new int[] { bottom, i };
                }
                left--;

                for (int i = bottom; i >= top && count < size; i--)
                {
                    if (left >= 0 && i < rows && i >= 0)
                        result[count++] = new int[] { i, left };
                }
                top--;
            }
            return result;
        }
    }
}
