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
    IList<IList<int>> ans;
    IList<int> currentList;
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        ans = new List<IList<int>>();
        if (root == null) return ans;
        currentList = new List<int>();

        dfs(root, 0, targetSum);

        return ans;
    }

    private void dfs(TreeNode currentNode, int currentSum, int targetSum)
    {
        currentSum += currentNode.val;
        currentList.Add(currentNode.val);
        if (currentNode.left == null && currentNode.right == null && currentSum == targetSum)
        {
            ans.Add(new List<int>(currentList));
        }

        if (currentNode.left != null)
        {
            dfs(currentNode.left, currentSum, targetSum);
        }

        if (currentNode.right != null)
        {
            dfs(currentNode.right, currentSum, targetSum);
        }
        currentList.RemoveAt(currentList.Count - 1);
    }
}
	