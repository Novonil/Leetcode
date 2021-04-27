using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.DFS
{
    class NumberOfIslandUnionFind
    {

        public class UnionFind
        {
            int[] parent;
            int[] rank;
            int count;
            public UnionFind(char[][] grid)
            {
                count = 0;
                int rows = grid.Length;
                int cols = grid[0].Length;
                parent = new int[rows * cols];
                rank = new int[rows * cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (grid[i][j] == '1')
                        {
                            parent[(i * cols) + j] = (i * cols) + j;

                            ++count;
                        }
                        rank[i * cols + j] = 0;
                    }
                }
            }

            public int find(int pos)
            {
                if (parent[pos] != pos)
                    parent[pos] = find(parent[pos]);
                return parent[pos];
            }

            public void Union(int pos1, int pos2)
            {
                int root1 = find(pos1);
                int root2 = find(pos2);
                if (root1 != root2)
                {
                    if (rank[root1] > rank[root2])
                    {
                        parent[root2] = root1;
                        //rank[root1] += rank[root2];
                        //rank[root2] = 0;
                    }
                    else if (rank[root1] < rank[root2])
                    {
                        parent[root1] = root2;
                        //rank[root2] += rank[root1];
                        //rank[root1] = 0;
                    }
                    else
                    {
                        parent[root2] = root1;
                        rank[root1] += 1;//rank[root2];
                                         //rank[root2] = 0;
                    }
                    --count;
                }
            }

            public int getCount()
            {
                return count;
            }
        }

        public static int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 1)
                return 0;

            int rows = grid.Length;
            int cols = grid[0].Length;

            UnionFind uf = new UnionFind(grid);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        grid[i][j] = '0';

                        if (i - 1 >= 0 && grid[i - 1][j] == '1')
                            uf.Union(i * cols + j, (i - 1) * cols + j);

                        if (i + 1 < rows && grid[i + 1][j] == '1')
                            uf.Union(i * cols + j, (i + 1) * cols + j);

                        if (j - 1 >= 0 && grid[i][j - 1] == '1')
                            uf.Union(i * cols + j, i * cols + j - 1);

                        if (j + 1 < cols && grid[i][j + 1] == '1')
                            uf.Union(i * cols + j, i * cols + j + 1);
                    }
                }
            }
            return uf.getCount();
        }
    }
}
