using System;
using System.Collections.Generic;
using System.Text;
using NetTopologySuite.Utilities;

namespace Leetcode.Heaps
{
	class UglyNumberII
	{
		public static int nthUglyNumber(int n)
		{
			if (n == 1)
				return 1;

			int[] primes = { 2,3,5 };
			PriorityQueue<long> minHeap = new PriorityQueue<long>();

			foreach(int prime in primes)
			{
				minHeap.Add(prime);
			}
			n--;
			long ans = 0;
			while(n > 0)
			{
				long top = minHeap.Peek();
				minHeap.Poll();
				if(top != ans)
				{
					n--;
					foreach (int prime in primes)
					{
						minHeap.Add(top * prime);
					}
				}
				ans = top;
			}
			return Convert.ToInt32(ans);
		}
	}
}
