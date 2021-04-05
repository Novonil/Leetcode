using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class SuperUglyNumber
	{
        public static int nthSuperUglyNumber(int n, int[] primes)
		{
			if (n == 1)
				return 1;

			long top = 0;
			long ans = 0;
			PriorityQueue<long> minHeap = new PriorityQueue<long>();
			foreach(int prime in primes)
			{
				minHeap.Add(prime);
			}

			n--;

			while(n > 0)
			{
				top = minHeap.Peek();
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
			return Convert.ToInt32(top);
		}

		public static int nthSuperUglyNumbers(int n, int[] primes)
		{
			PriorityQueue<long> q = new PriorityQueue<long>();
			q.Add(1L);
			foreach (int prime in primes)
			{
				q.Add((long)prime);
			}
			long ans = 0;
			while (n > 0)
			{
				long item = q.Poll();
				if (item != ans)
				{
					n--;
					foreach (int prime in primes)
					{
						q.Add(prime * item);
					}
				}
				ans = item;
			}
			return (int)ans;
		}


	}
}
