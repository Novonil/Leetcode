using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class TwoSumIIArrayIsSorted
	{
		public static int[] TwoSumBruteForce(int[] numbers, int target)
		{
			int[] result = new int[2];
			Dictionary<int, int> numberIndexMap = new Dictionary<int, int>();

			for (int i = 0; i < numbers.Length; i++)
			{
				if (numberIndexMap.ContainsKey(target - numbers[i]))
				{
					result[0] = numberIndexMap[target - numbers[i]];
					result[1] = i + 1;
				}
				else if (!numberIndexMap.ContainsKey(numbers[i]))
				{
					numberIndexMap.Add(numbers[i], i + 1);
				}
			}

			return result;
		}
		public static int[] TwoSumBinarySearch(int[] numbers, int target)
		{
			int n = numbers.Length;
			int start;
			int end;
			int mid;

			for (int i = 0; i < numbers.Length; i++)
			{
				start = i + 1;
				end = n - 1;
				while (start <= end)
				{
					mid = start + ((end - start) / 2);

					if (numbers[mid] == target - numbers[i])
					{
						return new[] { i + 1, mid + 1 };
					}
					else if (numbers[mid] < target - numbers[i])
					{
						start = mid + 1;
					}
					else
					{
						end = mid - 1;
					}
				}
			}
			return new[] { -1 };
		}
		public static int[] TwoSum(int[] numbers, int target)
		{
			int i = 0;
			int j = numbers.Length - 1;

			while (i < j)
			{
				int sum = numbers[i] + numbers[j];

				if (sum == target)
				{
					return new int[] { i + 1, j + 1 };
				}
				else if (sum > target)
				{
					j--;
				}
				else
				{
					i++;
				}
			}
			return new int[] { -1, -1 };
		}
	}
}
