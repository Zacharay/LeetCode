/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
	{
		public bool HasPathSum(TreeNode root, int targetSum)
		{
			bool targetSumFound = false;
            if (root == null) return targetSumFound;
			dfs(root,0,targetSum,ref targetSumFound);
			return targetSumFound;
		}
		private void dfs(TreeNode currentNode,int currentSum,int targetSum,ref bool targetSumFound)
		{
			currentSum += currentNode.val;
			if (currentNode.left == null&&currentNode.right == null&&currentSum==targetSum)
			{
				targetSumFound = true;
			}

			if(currentNode.left != null)
			{
				dfs(currentNode.left,currentSum,targetSum,ref targetSumFound);
			}

			if (currentNode.right != null)
			{
				dfs(currentNode.right,currentSum, targetSum, ref targetSumFound);
			}
			
		}
	}