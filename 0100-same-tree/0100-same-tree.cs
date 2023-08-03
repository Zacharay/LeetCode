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
	public bool IsSameTree(TreeNode p, TreeNode q)
	{

		if (p == null && q == null)
		{
			return true;
		}
		else if (p == null || q == null)
		{
			return false;
		}

		Queue<TreeNode> queue1 = new Queue<TreeNode>();
		Queue<TreeNode> queue2 = new Queue<TreeNode>();

		queue1.Enqueue(p);
		queue2.Enqueue(q);

		while (queue1.Count > 0 && queue2.Count > 0)
		{
			TreeNode firstNode = queue1.Dequeue();
			TreeNode secondNode = queue2.Dequeue();

			if (firstNode == null && secondNode == null)
			{
				continue;
			}

			if (firstNode == null || secondNode == null || firstNode.val != secondNode.val)
			{
				return false;
			}

			queue1.Enqueue(firstNode.left);
			queue1.Enqueue(firstNode.right);
			queue2.Enqueue(secondNode.left);
			queue2.Enqueue(secondNode.right);
		}

		return true;
	}
}