using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.SlidingWindow
{
	class MaxValueOfEquations
	{
        public static int FindMaxValueOfEquation(int[][] points, int k)
        {

            int max = int.MinValue;
            SortedSet<(int, int)> maxHeap = new SortedSet<(int YXdiff, int index)>(Comparer<(int YXdiff, int index)>.Create((a, b) =>
                                                                                        {
                                                                                            var result = b.YXdiff.CompareTo(a.YXdiff);
                                                                                            if (result == 0)
                                                                                            {
                                                                                                result = b.index.CompareTo(a.index);
                                                                                            }
                                                                                            return result;
                                                                                        }));

            maxHeap.Add((points[0][1] - points[0][0], 0));

            for (int i = 1; i < points.Length; i++)
			{
                var currPoint = points[i];
                
                while(maxHeap.Count > 0 && currPoint[0] - points[maxHeap.First().Item2][0] > k)
				{
                    maxHeap.Remove(maxHeap.First());
				}
                if(maxHeap.Count > 0)
				{
                    var heapTop = maxHeap.First();
                    int val = currPoint[0] + currPoint[1];
                    int value = val + heapTop.Item1;
                    max = Math.Max(max, value);
                }

                maxHeap.Add((currPoint[1] - currPoint[0], i));
			}
            return max;
        }
        public int FindMaxValueOfEquationBruteForce(int[][] points, int k)
        {
            int max = int.MinValue;

            for (int left = 0; left < points.Length - 1; left++)
            {
                for (int right = left + 1; right < points.Length; right++)
                {
                    int x = points[right][0] - points[left][0];
                    if (x <= k)
                    {
                        int y = points[right][1] + points[left][1] + x;
                        max = Math.Max(max, y);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return max;
        }
    }
}
