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
	public int MinDepth(TreeNode root)
	{
		if(root == null) return 0;
		else
		{
			return dfs(root, 1);
		}
	}
	private int dfs(TreeNode currentNode,int currentDepth)
	{
		if(currentNode.left == null && currentNode.right==null)
		{
			return currentDepth;
		}
		int left=int.MaxValue, right = int.MaxValue;
		if(currentNode.left != null) 
		{
			left = dfs(currentNode.left, currentDepth+1);
		}
		if (currentNode.right != null)
		{
			right = dfs(currentNode.right, currentDepth + 1);
		}
		int ans = Math.Min(left, right);

		return ans;
	}
}