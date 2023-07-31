public class Solution {
    List<int> par;
		private int find(int a)
		{
			if (par[a] == a) return a;
			else return find(par[a]);
		}
		private void union(int a, int b)
		{
			int p1 = find(a);
			int p2 = find(b);
			if (p1 != p2)
			{
				par[p1] = p2;
			}
		}
		public int FindCircleNum(int[][] isConnected)
		{
			int n = isConnected.Count();
			par = new List<int>();
			for (int i = 0; i < n; i++)
			{
				par.Add(i);
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (isConnected[i][j] == 1)
					{
						union(i, j);
					}
				}
			}
			HashSet<int> ans = new HashSet<int>();

			for (int i = 0; i < n; i++)
			{
					int parent = find(par[i]);
					ans.Add(parent);
			}


			return ans.Count();
		}
	
}