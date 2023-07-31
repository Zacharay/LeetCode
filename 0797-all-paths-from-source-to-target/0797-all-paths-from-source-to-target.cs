using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;



	public class Solution
	{
		IList<IList<int>> ans;
		IList<int> currentList;
		public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
		{
			int n = graph.Count();
			ans = new List<IList<int>>(); 
			currentList = new List<int>(); 
			dfs(0,graph,n);
			return ans;
		}
		private void dfs(int src, int[][] graph,int n)
		{
			currentList.Add(src);
			if(n-1==src)
			{
				Console.WriteLine("xd");
				ans.Add(new List<int>(currentList));
			}
			for(int i=0;i< graph[src].Count();i++)
			{
				dfs(graph[src][i], graph,n);
			}
			currentList.Remove(src);
		}
	}


