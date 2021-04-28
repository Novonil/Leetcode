using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.DFS
{
	class NumberOfIslandsII
	{
        public class Solution
        {
            public class UnionFind
            {
                public int[] parent;
                public int[] rank;

                public UnionFind(int m, int n)
                {
                    parent = new int[m * n];
                    rank = new int[m * n];
                    Array.Fill(parent, -1);
                }

                public int Find(int pos)
                {
                    if (parent[pos] != pos)
                        parent[pos] = Find(parent[pos]);
                    return parent[pos];
                }

                public int Union(int pos1, int pos2, int numOfIslands)
                {
                    int root1 = Find(pos1);
                    int root2 = Find(pos2);

                    if (root1 != root2)
                    {
                        if (rank[root1] > rank[root2])
                            parent[root2] = root1;
                        else if (rank[root1] < rank[root2])
                            parent[root1] = root2;
                        else
                        {
                            parent[root2] = root1;
                            rank[root1] += 1;
                        }
                        numOfIslands--;
                    }
                    return numOfIslands;
                }
            }

            public static IList<int> NumIslands2(int m, int n, int[][] positions)
            {
                IList<int> numberOfIslands = new List<int>();
                int numOfIslands = 0;

                //int[][] grid = new int[m][];
                //for(int i = 0; i<m; i++)
                //{
                //    grid[i] = new int[n];
                //}

                UnionFind uf = new UnionFind(m, n);

                foreach (int[] position in positions)
                {
                    int row = position[0];
                    int col = position[1];

                    //grid[row][col] = 1;

                    int currentIndex = row * n + col;

                    if (uf.parent[currentIndex] == -1)
                    {
                        numOfIslands++;
                        uf.parent[currentIndex] = currentIndex;
                    }
                    else
                    {
                        numberOfIslands.Add(numOfIslands);
                        continue;
                    }

                    int neighbourIndex = (row - 1) * n + col;
                    if (row - 1 >= 0 && uf.parent[neighbourIndex] != -1)
                    {
                        numOfIslands = uf.Union(currentIndex, neighbourIndex, numOfIslands);
                    }
                    neighbourIndex = (row + 1) * n + col;
                    if (row + 1 < m && uf.parent[neighbourIndex] != -1)
                    {
                        numOfIslands = uf.Union(currentIndex, neighbourIndex, numOfIslands);
                    }
                    neighbourIndex = row * n + col - 1;
                    if (col - 1 >= 0 && uf.parent[neighbourIndex] != -1)
                    {
                        numOfIslands = uf.Union(currentIndex, neighbourIndex, numOfIslands);
                    }
                    neighbourIndex = row * n + col + 1;
                    if (col + 1 < n && uf.parent[neighbourIndex] != -1)
                    {
                        numOfIslands = uf.Union(currentIndex, neighbourIndex, numOfIslands);
                    }

                    numberOfIslands.Add(numOfIslands);
                }
                return numberOfIslands;
            }
        }
    }
}
