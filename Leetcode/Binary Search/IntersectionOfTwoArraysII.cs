using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class IntersectionOfTwoArraysII
	{
		public static int[] Intersect(int[] nums1, int[] nums2)
		{
			Dictionary<int, int> keyFrequency1 = new Dictionary<int, int>();
			Dictionary<int, int> keyFrequency2 = new Dictionary<int, int>();
			List<int> result = new List<int>();

			for (int i = 0; i < nums1.Length; i++)
			{
				if (!keyFrequency1.ContainsKey(nums1[i]))
				{
					keyFrequency1.Add(nums1[i], 1);
				}
				else
				{
					keyFrequency1[nums1[i]] = keyFrequency1[nums1[i]]++;
				}
			}
			for (int i = 0; i < nums2.Length; i++)
			{
				if (!keyFrequency2.ContainsKey(nums2[i]))
				{
					keyFrequency2.Add(nums2[i], 1);
				}
				else
				{
					keyFrequency2[nums2[i]] = keyFrequency2[nums2[i]]++;
				}
			}

			foreach (KeyValuePair<int, int> KV in keyFrequency1)
			{
				if (keyFrequency2.ContainsKey(KV.Key))
				{
					for (int i = 1; i <= Math.Min(KV.Value, keyFrequency2[KV.Key]); i++)
					{
						result.Add(KV.Key);
					}
				}
			}
			return result.ToArray();
		}
		public static int[] IntersectBruteForce(int[] nums1, int[] nums2)
		{
			HashSet<int> indexesConsidered = new HashSet<int>();
			List<int> result = new List<int>();

			for (int i = 0; i < nums1.Length; i++)
			{
				for (int j = 0; j < nums2.Length; j++)
				{
					if (!indexesConsidered.Contains(j) && nums1[i] == nums2[j])
					{
						indexesConsidered.Add(j);
						result.Add(nums1[i]);
						break;
					}
				}
			}
			return result.ToArray();
		}

		public int[] IntersectOptimized(int[] nums1, int[] nums2)
		{
			Dictionary<int, int> keyFreq = new Dictionary<int, int>();

			List<int> res = new List<int>();

			foreach (int i in nums1)
			{
				if (!keyFreq.ContainsKey(i))
				{
					keyFreq.Add(i, 1);
				}
				else
				{
					keyFreq[i]++;
				}
			}

			foreach (int i in nums2)
			{
				int c = keyFreq.GetValueOrDefault(i, 0);

				if (c > 0)
				{
					res.Add(i);
					keyFreq[i] = c - 1;
				}
			}

			return res.ToArray();
		}
		public int[] IntersectSorted(int[] nums1, int[] nums2)
		{
			return new int[] { };
		}
	}
}
