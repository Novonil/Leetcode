using NetTopologySuite.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Heaps
{
	class NumberOfOrdersInBacklog
	{
		public static int getNumberOfBacklogOrders(int[][] orders)
		{
			PriorityQueue<(int,int)> buy = new PriorityQueue<(int,int)>(orders.Length, Comparer<(int,int)>.Create((a,b) => { return b.Item1.CompareTo(a.Item1); }));
			PriorityQueue<(int,int)> sell = new PriorityQueue<(int,int)>(orders.Length, Comparer<(int,int)>.Create((a,b) => { return a.Item1.CompareTo(b.Item1); }));

			foreach(int[] order in orders)
			{
				if(order[2] == 0)
				{
					while(sell.Size > 0 && sell.Peek().Item1 <= order[0] && order[1] > 0)
					{
						int sellPrice = sell.Peek().Item1;
						int sellQuantity = sell.Peek().Item2;
						sell.Poll();
						if(order[1] > sellQuantity)
						{
							order[1] -= sellQuantity;
							sellQuantity = 0;
						}
						else if(order[1] < sellQuantity)
						{
							sellQuantity -= order[1];
							order[1] = 0;
							sell.Add((sellPrice,sellQuantity)) ;
						}
						else
						{
							order[1] = 0;
							sellQuantity = 0;
						}
					}
					if(order[1] > 0)
					{
						buy.Add((order[0], order[1]));
					}
				}
				else
				{
					while(buy.Size > 0 && buy.Peek().Item1 >= order[0] && order[1] > 0)
					{
						int buyPrice = buy.Peek().Item1;
						int buyQuantity = buy.Peek().Item2;
						buy.Poll();
						if(order[1] > buyQuantity)
						{
							order[1] -= buyQuantity;
							buyQuantity = 0;
						}
						else if(order[1] < buyQuantity)
						{
							buyQuantity -= order[1];
							order[1] = 0;
							buy.Add((buyPrice,buyQuantity));
						}
						else
						{
							buyQuantity = 0;
							order[1] = 0;
						}
					}
					if(order[1] > 0)
					{
						sell.Add((order[0],order[1]));
					}
				}
			}
			return countBacklog(buy, sell);
		}

		public static int countBacklog(PriorityQueue<(int,int)> buy, PriorityQueue<(int,int)> sell)
		{
			int modulo = 1000000007;
			int count = 0;
			while(buy.Size > 0 || sell.Size > 0)
			{
				if(buy.Size > 0)
				{
					count += buy.Peek().Item2;
					buy.Poll();
				}
				if(sell.Size > 0)
				{
					count += sell.Peek().Item2;
					sell.Poll();
				}
			}
			return count % modulo;
		}
	}
}
