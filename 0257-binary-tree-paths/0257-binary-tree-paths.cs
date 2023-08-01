public class Solution
{
    IList<string> paths;
    IList<int> currentPath;
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        paths = new List<string>(); 
        if (root == null) return paths;
        currentPath = new List<int>();
        dfs(root);
        return paths;
    }

    private void dfs(TreeNode currentNode)
    {
        if (currentNode == null) return;

        currentPath.Add(currentNode.val);
        if (currentNode.left == null && currentNode.right == null)
        {
            string temp = string.Join("->", currentPath); 
            paths.Add(temp);
            currentPath.RemoveAt(currentPath.Count - 1);
            return;
        }

        if (currentNode.left != null)
        {
            dfs(currentNode.left);
        }
        if (currentNode.right != null)
        {
            dfs(currentNode.right);
        }

        currentPath.RemoveAt(currentPath.Count - 1);
    }
}