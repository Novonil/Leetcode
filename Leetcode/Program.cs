using Leetcode.Arrays;
using Leetcode.Binary_Search;
using Leetcode.DFS;
using Leetcode.Dynamic_Programming;
using Leetcode.Heaps;
using Leetcode.SlidingWindow;
using Leetcode.Stack;
using Leetcode.Stacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Leetcode.Arrays.KadanesIn2D;
using static Leetcode.DFS.EmployeeImportance;
using static Leetcode.DFS.NumberOfIslandsII;
using static Leetcode.Dynamic_Programming.HouseRobberIII;
using MaximalRectangle = Leetcode.Stacks.MaximalRectangle;
using Leetcode.Segment_Tree;

namespace Leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
			//int[] num1 = { 1, 5, 9 };
			//int[] num2 = { 10, 11, 13 };//, 1, 1, 0 };
			//int[] num3 = { 12, 13, 15 };//, 0, 0, 0 };
			//int[] num4 = { 1, 1 };//, 0, 0, 0 };
			//int[] num5 = { 1, 1, 1, 1, 1 };

			//int[][] nums = new int[3][];
			//nums[0] = num1;
			//nums[1] = num2;
			//nums[2] = num3;
			//nums[3] = num4;
			//nums[4] = num5;


			//Console.WriteLine(KthSmallestElementInASortedMatrix.KthSmallest(nums, 8	));


			//Console.WriteLine(ArrangingCoins.ArrangeCoins(3));
			//CustomFunction customfunction = new CustomFunction();
			//Console.WriteLine(FindPositiveIntegerSolutionForAGivenEquation.FindSolution(customfunction, 6));
			//int[] arr = /*MedianOfTwoSortedArrays.FindMedianSortedArrays*/(num1,num2);

			//IList<IList<int>> l = new List<IList<int>>();
			//int[] l = TwoSumIIArrayIsSorted.TwoSum(num1, 9);

			//foreach (int i in l)
			//{
			//	Console.WriteLine(i);
			//}
			//int[] num = { 0, 0, 0, 1, 0, 1, 1, 0 };


			//int[] nums1 = { 0, 1, 0, 1, 0, 1, 0, 1 };
			//string s = "ABAB";
			//string t = "havefunonleetcode";

			//int res = MinimumNumberOfKConsecutiveBitFlips.MinKBitFlips(num, 3);

			//int[] num = { 4, 5, 8, 2 };
			//int res = LastStoneWeight.lastStoneWeight(num);


			//KthLargestEkementInAStream k = new KthLargestEkementInAStream(3, num);

			//Console.WriteLine(k.Add(3));
			//Console.WriteLine(k.Add(5));
			//Console.WriteLine(k.Add(10));
			//Console.WriteLine(k.Add(9));
			//Console.WriteLine(k.Add(4));


			//int[][] arr = new int[2][];
			//arr[0] = new int[] { 1,3 };
			//arr[1] = new int[] { -2, 2};

			//int[][] res = KClosestPointsToOrigin.KClosest(arr, 1);

			//foreach(int[] r in res)
			//{
			//	Console.WriteLine(r[0] + " , " + r[1]);
			//}


			//string s = "Aabb";
			//Console.WriteLine(SortChractersByFrequency.FrequencySort(s));


			//int[] arr = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };

			//int res = KthLargestElementInAnArray.findKthLargest(arr, 4);
			//foreach (int r in res)

			//string[] s = { "i", "love", "leetcode", "i", "love", "coding" };


			//IList<string> res = TopKFrequentWords.TopKFrequent(s, 2);
			//foreach(string sr in res)
			//{
			//	Console.WriteLine(sr);
			//}

			//int[][] matrix = new int[3][];
			//matrix[0] = new int[] { 1, 5, 9 };
			//matrix[1] = new int[] { 10, 11, 13 };
			//matrix[2] = new int[] { 12, 13, 15 };

			//int res = Heaps.MaximumScoreFromRemovingStones.MaximumScoreHeap(4,4,6);,


			//int[][] n = new int[3][];
			//n[0] = new int[] { 1,2 };
			//n[1] = new int[] { 3, 5 };
			//n[2] = new int[] { 2, 2 };

			//double res = MaximumAveragePassRatio.maxAverageRatio(n, 2);

			//string res = ReorganizeString.ReorganizeStringFunc("aab");
			//int res = KadanesInOneD.maximumSubarraySum(new int[] { 4, 3, -2, 6, -14, 7, -1, 4, 5, 7, -10, 2, 9, -10, -5 - 9, 6, 1 });

			//int[,] re = {
			//				{ 2, 1, -3, -4, 5},
			//				{ 0, 6, 3, 4, 1 },
			//				{ 2, -2, -1, 4, -5},
			//				{ -3, 3, 1, 0, 3}
			//			};

			//int[][] meetings = new int[3][];
			//meetings[0] = new int[] { 0, 30 };
			//meetings[1] = new int[] { 5, 10 };
			//meetings[2] = new int[] { 15, 20 };

			//int[] arr = { 1, 2, 3, 4, 4, 5 };
			//int res = UglyNumberII.nthUglyNumber(1);


			//int[][] arr = new int[4][];
			//arr[0] = new int[] { 7, 1000000000, 1 };
			//arr[1] = new int[] { 15, 3, 0 };
			//arr[2] = new int[] { 5, 999999995, 0 };
			//arr[3] = new int[] { 5, 1, 1 };

			//int[] arr1 = { 1, 7, 11 };
			//int[] arr2 = { 2, 4, 6 };

			//string[] str = { "d1/", "d2/", "../", "d21/", "./" };

			//int[] nums1 = { 2,4 };
			//int[] nums2 = { 1, 2, 3, 4 };
			//Leetcode.Stacks.NextGreaterElementI ob = new Leetcode.Stacks.NextGreaterElementI();
			//int[] res = Leetcode.Stacks.NextGreaterElementI.res(nums1,nums2);
			//BackspaceStringCompare ob = new BackspaceStringCompare();
			//bool res = Leetcode.Stacks.ValidParenthesis.IsValid("()");

			//Leetcode.Stacks.MinStack ms = new Leetcode.Stacks.MinStack();
			//ms.Push(2147483646);
			//ms.Push(2147483646);
			//ms.Push(2147483647);
			//Console.WriteLine(ms.Top());
			//ms.Pop();
			//Console.WriteLine(ms.GetMin());
			//ms.Pop();
			//Console.WriteLine(ms.GetMin());
			//ms.Pop();
			//ms.Push(2147483647);
			//Console.WriteLine(ms.Top());
			//Console.WriteLine(ms.GetMin());
			//ms.Push(-2147483648);
			//Console.WriteLine(ms.Top());
			//Console.WriteLine(ms.GetMin());
			//ms.Pop();
			//Console.WriteLine(ms.GetMin());

			//Console.WriteLine(res);
			//foreach (int i in res)
			//	Console.WriteLine(i);

			//DesignAStackWIthIncrementOperation d = new DesignAStackWIthIncrementOperation(3);
			//d.Push(1);
			//d.Push(2);
			//Console.WriteLine(d.Pop());
			//d.Push(2);
			//d.Push(3);
			//d.Push(4);
			//d.Increment(5,100);
			//d.Increment(2,100);
			//Console.WriteLine(d.Pop());
			//Console.WriteLine(d.Pop());
			//Console.WriteLine(d.Pop());
			//Console.WriteLine(d.Pop());

			//string str = "0";
			//Console.WriteLine(str[0] - '1');
			//StringBuilder sb = new StringBuilder();
			//sb.Insert(0,'a');

			//sb.Append(String.Concat(Enumerable.Repeat("xyz",5)));
			//Console.WriteLine(sb.ToString());
			//Leetcode.Stacks.OnlineStockSpan ob = new Leetcode.Stacks.OnlineStockSpan();
			//Console.WriteLine(ob.Next(100));
			//Console.WriteLine(ob.Next(80));
			//Console.WriteLine(ob.Next(60));
			//Console.WriteLine(ob.Next(70));
			//Console.WriteLine(ob.Next(60));
			//Console.WriteLine(ob.Next(75));
			//Console.WriteLine(ob.Next(85));

			//bool s = ValidateStackSequences.ValidateStackSequence(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 2, 1 });

			//Stack<(char, int)> stack = new Stack<(char, int)>();
			//stack.Push(('a',2));
			//stack.Push(('a', 3));
			//stack.Push(('b', 4));
			//int count = stack.Sum(x => x.Item2);


			//int[][] mat = new int[4][];

			//mat[0] = new int[] { 1,0,1,0,0 };
			//mat[1] = new int[] { 1,0,1,1,1 };
			//mat[2] = new int[] { 1,1,1,1,1 };
			//mat[3] = new int[] { 1,0,0,1,0 };



			//MaximalRectangle mr = new MaximalRectangle();
			//int s = mr.MaximalRectangleArea(mat);

			//string s = RemoveAllAdjacentDuplicatesInStringII.RemoveDuplicates("deeedbbcccbdaa", 3);
			//IList<string> inp = new List<string>();
			//inp.Add("0:start:0");
			//inp.Add("1:start:2");
			//inp.Add("1:end:5");
			//inp.Add("0:end:6");
			//TreeNode tr = new TreeNode(3);
			//tr.left = new TreeNode(2);
			//tr.right = new TreeNode(3);
			//tr.left.right = new TreeNode(3);
			//tr.right.right = new TreeNode(1);

			//int[][] nums = new int[10][];
			//nums[0] = new int[] { 0, 0, 1, 1, 0, 1, 0, 0, 1, 0 };
			//nums[1] = new int[] { 1,1,0,1,1,0,1,1,1,0 };
			//nums[2] = new int[] { 1,0,1,1,1,0,0,1,1,0 };
			//nums[3] = new int[] { 0,1,1,0,0,0,0,1,0,1 };
			//nums[4] = new int[] { 0,0,0,0,0,0,1,1,1,0 };
			//nums[5] = new int[] { 0,1,0,1,0,1,0,1,1,1 };
			//nums[6] = new int[] { 1,0,1,0,1,1,0,0,0,1 };
			//nums[7] = new int[] { 1,1,1,1,1,1,0,0,0,0 };
			//nums[8] = new int[] { 1,1,1,0,0,1,0,1,0,1 };
			//nums[9] = new int[] { 1,1,1,0,1,1,0,1,1,0 };

			////[[0,1],[1,2],[2,1],[1,0],[0,2],[0,0],[1,1]]

			//char[][] pos = new char[3][];
			//pos[0] = new char[] { 'O', 'O', 'O' };
			//pos[1] = new char[] { 'O', 'O', 'O' };
			//pos[2] = new char[] { 'O', 'O', 'O' };
			//pos[2] = new int[] { 1, 2 };
			//pos[3] = new int[] { 2, 1 };

			//pos[4] = new int[] { 0, 2 };
			//pos[5] = new int[] { 0, 0 };
			//pos[6] = new int[] { 1, 1 };

			//nums[0] = new char[] { '1','1','1','1','1','0','1','1','1','1'};
			//nums[1] = new char[] { '1','0','1','0','1','1','1','1','1','1'};
			//nums[2] = new char[] { '0','1','1','1','0','1','1','1','1','1'};
			//nums[3] = new char[] { '1','1','0','1','1','0','0','0','0','1'};
			//nums[4] = new char[] { '1','0','1','0','1','0','0','1','0','1'};
			//nums[5] = new char[] { '1','0','0','1','1','1','0','1','0','0'};
			//nums[6] = new char[] { '0','0','1','0','0','1','1','1','1','0'};
			//nums[7] = new char[] { '1','0','1','1','1','0','0','1','1','1'};
			//nums[8] = new char[] { '1','1','1','1','1','1','1','1','0','1'};
			//nums[9] = new char[] { '1','0','1','1','1','1','1','1','1','0'};
			//IList<int> res = Solution.NumIslands2(3,3,pos);
			//Leetcode.BFS.SuroundedRegions.Solve(pos);
			//StringBuilder sb = new StringBuilder();
			//sb.Append()
			//Console.WriteLine(res);

			//Leetcode.BFS.NumberOfClosedIslands.ClosedIsland(nums);

			//Employee e = new Employee();
			//e.id = 1;
			//e.importance = 5;
			//e.subordinates = new List<int>();
			//e.subordinates.Add(2);
			//e.subordinates.Add(3);

			//Employee e1 = new Employee();
			//e1.id = 2;
			//e1.importance = 3;
			//e1.subordinates = new List<int>();

			//Employee e2 = new Employee();
			//e2.id = 3;
			//e2.importance = 3;
			//e2.subordinates = new List<int>();

			//IList<Employee> emp = new List<Employee>();

			//emp.Add(e);
			//emp.Add(e1);
			//emp.Add(e2);

			//EmployeeImportance.GetImportance(emp, 1);
			//int n = TimeNeededToInformAllEmployees.NumOfMinutes(15, 0, new int[] { -1, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 });

			//Leetcode.DFS.DeleteNodesAndReturnForest.TreeNode root = new Leetcode.DFS.DeleteNodesAndReturnForest.TreeNode(1);
			//root.left = new DeleteNodesAndReturnForest.TreeNode(2);
			//root.right = new DeleteNodesAndReturnForest.TreeNode(3);
			//root.left.left = new DeleteNodesAndReturnForest.TreeNode(4);
			//root.left.right = new DeleteNodesAndReturnForest.TreeNode(5);
			//root.right.left = new DeleteNodesAndReturnForest.TreeNode(6);
			//root.right.right = new DeleteNodesAndReturnForest.TreeNode(7);

			//DeleteNodesAndReturnForest.DelNodes(root, new int[] { 3,5 });
			//Console.WriteLine(n);

			//int[] arr = { -1, 2, 4, 0 };
			//int len = arr.Length;
			//int[] segmentTree = new int[2 * len - 1];
			//Implementation.buildSegmentTreeFromArray(arr, segmentTree, 0, len - 1, 0);
			//foreach (int i in segmentTree)
			//	Console.WriteLine(i);

			//int min = Implementation.minInRange(segmentTree, 0, 3, 0, 3, 0);
			//Console.WriteLine(min);


			//IList<IList<string>> accounts = new List<IList<string>>();
			//IList<string> account = new List<string>();

			//account.Add("John");
			//account.Add("johnsmith@mail.com");
			//account.Add("john_newyork@mail.com");
			//accounts.Add(account);

			//IList<string> account1 = new List<string>();
			//account1.Add("John");
			//account1.Add("johnsmith@mail.com");
			//account1.Add("john00@mail.com");
			//accounts.Add(account1);

			//IList<string> account3 = new List<string>();
			//account3.Add("Mary");
			//account3.Add("mary@mail.com");
			//accounts.Add(account3);

			//IList<string> account2 = new List<string>();
			//account2.Add("John");
			//account2.Add("johnnybravo@mail.com");
			//accounts.Add(account2);

			//IList<IList<string>> res = AccountsMerge.AccountsMerges(accounts);

			//int[][] matrix = new int[3][];
			//matrix[0] = new int[] { 1,2,3,4 };
			//matrix[1] = new int[] { 5, 6,7,8 };
			//matrix[2] = new int[] { 10, 11, 12, 13 };

			//IList<int> result = SpiralMatrix.SpiralOrder(matrix);
			//Class1.countKDistinctSubstrings("aaaaaaa",1);
			int[] arr = { 1,0,1,1,1 };
			//bool index = SearchInARotatedSortedArrayI.Search(arr, 0);
			//Console.WriteLine(index);
			Console.ReadLine();
		}
	}
}
