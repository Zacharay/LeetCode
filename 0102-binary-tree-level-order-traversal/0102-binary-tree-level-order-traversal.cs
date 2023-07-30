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
public class TreeNodeWithLevel
{
	public TreeNode Node { get; set; }
	public int Level { get; set; }
}

public class Solution
{
	public IList<IList<int>> LevelOrder(TreeNode root)
	{
		IList<IList<int>> ans = new List<IList<int>>();
		if(root == null) return ans;

		Queue<TreeNodeWithLevel> q = new Queue<TreeNodeWithLevel>();
		q.Enqueue(new TreeNodeWithLevel { Node = root ,Level=0});

		while (q.Count > 0)
		{
			TreeNodeWithLevel nodeWithLevel = q.Dequeue();
			TreeNode node= nodeWithLevel.Node;
			
			int level = nodeWithLevel.Level;
			if (level >= ans.Count)
			{
				ans.Add(new List<int>());
			}
			ans[level].Add(node.val);
			if (node.left!= null)
			{
				q.Enqueue(new TreeNodeWithLevel { Node = node.left, Level = level+1 });
			}
			if(node.right!= null)
			{
				q.Enqueue(new TreeNodeWithLevel { Node = node.right, Level = level + 1 });
			}
		}

		return ans;
	}
}