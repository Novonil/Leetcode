using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Dynamic_Programming
{
	class HouseRobberIII
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

        static Dictionary<TreeNode, int[]> map = new Dictionary<TreeNode, int[]>();

        public static int Rob(TreeNode root)
        {
            int[] res = dfs(root);
            return Math.Max(res[0], res[1]);
        }

        //[with Root, without Root]
        public static int[] dfs(TreeNode root)
        {
            if (root == null)
                return new int[] { 0, 0 };

            if (map.ContainsKey(root))
                return map[root];

            int[] leftPair = dfs(root.left);
            int[] rightPair = dfs(root.right);

            int withRoot = root.val + leftPair[1] + rightPair[1];
            int withoutRoot = Math.Max(leftPair[0], leftPair[1]) + Math.Max(rightPair[0], rightPair[1]);

            map[root] = new int[] { withRoot, withoutRoot };

            return map[root];
        }
        
    }
}
