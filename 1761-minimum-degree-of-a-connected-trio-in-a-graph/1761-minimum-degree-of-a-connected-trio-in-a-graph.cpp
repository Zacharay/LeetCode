class Solution {
public:
    int minTrioDegree(int n, vector<vector<int>> edges) {

	int g[401][401]{0};
	vector<int>degree(n+1,0);
 	for(int i=0;i<edges.size();i++)
 	{
 		int u = edges[i][0];
 		int v = edges[i][1];
 		degree[u]++;
 		degree[v]++;
 		g[u][v]=1;
 		g[v][u]=1;
 	}
 	int ans = INT_MAX;
 	for(int i=1;i<=n;i++)
 	{
 		for(int j=1;j<=n;j++)
 		{
 			for(int k=1;k<=n;k++)
 			{
 				if(g[i][j]&&g[i][k]&&g[j][k])
 				{
 					ans = min(ans,degree[i]+degree[j]+degree[k]-6);
 				}
 			}
 		}
 	}
 	if(ans==INT_MAX)
 		return -1;
 	return ans;
    }
};