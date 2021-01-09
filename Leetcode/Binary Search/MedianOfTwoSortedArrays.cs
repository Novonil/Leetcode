using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class MedianOfTwoSortedArrays
	{
		public static double FindMedianSortedArraysBruteForce(int[] nums1, int[] nums2)
		{
			int m = nums1.Length;
			int n = nums2.Length;
			int[] mergedArray = new int[m + n];
			int i = 0, j = 0, current = 0;

			while (i < m && j < n)
			{
				if (nums1[i] < nums2[j])
				{
					mergedArray[current++] = nums1[i++];
				}
				else
				{
					mergedArray[current++] = nums2[j++];
				}
			}
			while (i < m)
			{
				mergedArray[current++] = nums1[i++];
			}
			while (j < n)
			{
				mergedArray[current++] = nums2[j++];
			}

			if ((m + n) % 2 == 0)
			{
				return (mergedArray[(m + n) / 2] + mergedArray[((m + n) / 2) - 1]) / 2.0;
			}
			return mergedArray[((m + n) / 2)];
		}
		public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			
			if(nums1.Length > nums2.Length)
			{
				return FindMedianSortedArrays(nums2, nums1);
			}

			int m = nums1.Length;
			int n = nums2.Length;
			int i, j;
			int start = 0, end= m;
			int halfLen = (m + n + 1)/ 2;

			while(start <= end)
			{
				i = start + (end - start) / 2;
				j = halfLen - i;

				if(i<end && nums2[j - 1] > nums1[i])
				{
					start = i + 1;
				}
				else if(i>start && nums1[i - 1] > nums2[j])
				{
					end = i - 1;
				}
				else
				{
					int maxLeft;
					if(i == 0)
					{
						maxLeft = nums2[j - 1];
					}
					else if(j==0)
					{
						maxLeft = nums1[i - 1];
					}
					else
					{
						maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]);
					}
					if ((m + n) % 2 == 1)
						return maxLeft;

					int minRight;
					if(i==m)
					{
						minRight = nums2[j];
					}
					else if(j == n)
					{
						minRight = nums1[i];
					}
					else
					{
						minRight = Math.Min(nums1[i], nums2[j]);
					}
					return (maxLeft + minRight) / 2.0;
				}
			}
			return 0.00;
		}
	}
}
