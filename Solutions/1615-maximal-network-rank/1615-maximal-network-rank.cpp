class Solution {
public:
    int maximalNetworkRank(int n, vector<vector<int>> roads) {
	vector<int>g[107];
	for(int i=0;i<roads.size();i++)
	{
		int u = roads[i][0];
		int v = roads[i][1];

		g[u].push_back(v);
		g[v].push_back(u);
	}


	int max_ans = -1;
	for(int i=0;i<n;i++)
		for(int j=i+1;j<n;j++)
		{
			int ans = g[i].size()+g[j].size();
			for(int k=0;k<g[i].size();k++)
				if(g[i][k]==j)
					ans--;
			max_ans = max(max_ans,ans);
		}
	return max_ans;

}
};