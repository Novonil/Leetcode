using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class PowXN
	{
        public static double MyPow(double x, int n)
        {
            int counter = -1;
            List<(double, int)> powers = new List<(double, int)>();
            bool negative = true;

            if (n == 0)
                return 1;

            if (n > 0)
            {
                n *= -1;
                negative = false;
            }

            powers.Add((x, counter));

            while (counter >= n/2)
            {
                x *= x;
                counter *= 2;
                powers.Add((x, counter));
            }

            for (int i = powers.Count - 1; i >= 0; i--)
            {
                if (counter >= n - powers[i].Item2)
                {
                    x *= powers[i].Item1;
                    counter += powers[i].Item2;
                }
            }
            return negative ? 1 / x : x;
        }
    }
}
