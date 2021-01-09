using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Binary_Search
{
	class FindSmallestLetterGreaterThanTarget
	{
		public static char NextGreatestLetter(char[] letters, char target)
		{
			int start = 0;
			int end = letters.Length - 1;
			int mid;
			int n = letters.Length;

			while(start<=end)
			{
				mid = start + (end - start) / 2;
				if(letters[mid] <= target)
				{
					start = mid + 1;
				}
				else
				{
					end = mid - 1;
				}
			}
			return letters[start % n];
		}
	}
}
