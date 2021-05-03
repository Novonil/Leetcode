using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.DFS
{
	class DeleteNodesAndReturnForest
	{
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                    this.val = val;
                    this.left = left;
                    this.right = right;
            }
        }
        static IList<TreeNode> result;
        public static IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            result = new List<TreeNode>();
            HashSet<int> delete = new HashSet<int>(to_delete);
            dfs(root, delete);
            return result;
        }

        public static void dfs(TreeNode root, HashSet<int> delete)
        {

            if (root == null)
                return;

            if (!delete.Contains(root.val))
                result.Add(root);

            else
                result.Add(null);

            dfs(root.left, delete);
            dfs(root.right, delete);

        }
    }
}
