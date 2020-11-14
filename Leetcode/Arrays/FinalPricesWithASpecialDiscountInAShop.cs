using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Arrays
{
	class FinalPricesWithASpecialDiscountInAShop
	{
		public int[] FinalPrices(int[] prices)
		{
			int[] arr = new int[prices.Length];
			for(int i = 0; i<prices.Length; i++)
			{
				arr[i] = prices[i];
				for(int j = i+1; j<prices.Length; j++)
				{
					if (prices[i] >= prices[j])
					{
						arr[i] = arr[i] - prices[j];
						break;
					}
				}
			}
			return arr;
		}
	}
}
