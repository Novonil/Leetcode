using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class DivideTwoIntegers
	{
        public static int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1)
                return int.MaxValue;

            if (dividend == 0)
                return dividend;

            int multiple = -1;
            int negative = 2;
            List<(int, int)> multiples = new List<(int, int)>();
            int quotient = 0;

            if (dividend > 0)
            {
                dividend = -dividend;
                negative--;
            }
            if (divisor > 0)
            {
                divisor = -divisor;
                negative--;
            }
            multiples.Add((multiple, divisor));

            while (dividend - divisor <= divisor)
            {
                divisor += divisor;
                multiple += multiple;
                multiples.Add((multiple, divisor));
            }
            quotient = multiple;
            dividend -= divisor;

            for (int i = multiples.Count - 1; i >= 0; i--)
            {
                if (dividend <= multiples[i].Item2)
                {
                    quotient += multiples[i].Item1;
                    dividend += multiples[i].Item2;
                }
            }
            if (negative == 1)
                return quotient;
            return -quotient;
        }
    }
}
