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
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> ans = new List<int>();
		if (root == null) return ans;
		dfs(ans, root);
		return ans;
    }
    private void dfs(IList<int>ans,TreeNode currentNode)
	{
		if(currentNode.left != null)
		{
			dfs(ans,currentNode.left);
		}
		if(currentNode.right != null)
		{
			dfs(ans,currentNode.right);
		}
		ans.Add(currentNode.val);
	}
}