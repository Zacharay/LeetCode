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
	public int MaxDepth(TreeNode root)
	{
		if (root == null) return 0;
		else
		{
			return dfs(root, 1, 0);
		}
	}
	private int dfs(TreeNode currentNode,int currentDepth,int maxDepth)
	{
		if(currentNode.left!= null)
		{
			maxDepth = Math.Max(dfs(currentNode.left, currentDepth + 1, maxDepth), maxDepth);
		}
			
		if (currentNode.right != null)
		{
			maxDepth = Math.Max(dfs(currentNode.right, currentDepth + 1, maxDepth), maxDepth);
			
		}
		maxDepth = Math.Max(maxDepth, currentDepth);

		return maxDepth;
	}
}