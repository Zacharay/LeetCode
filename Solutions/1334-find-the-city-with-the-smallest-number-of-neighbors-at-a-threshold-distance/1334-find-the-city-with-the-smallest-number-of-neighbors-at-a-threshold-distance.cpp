class Solution {
public:
    int findTheCity(int n, vector<vector<int>> edges, int distanceThreshold) {
       	vector<int>g[n+1];

       	for(int i=0;i<n;i++)
       	{
       			for(int j=0;j<n;j++)
       			{
       				if(i==j)
       					g[i].push_back(0);
       				else{
       					g[i].push_back(INT_MAX);
       				}
       			}
       	}

       	for(int i=0;i<edges.size();i++)
       	{
       		int a = edges[i][0];
       		int b = edges[i][1];
       		int wt = edges[i][2];

       		g[a][b]=wt;
       		g[b][a]=wt;
       	}

       	for(int k = 0;k<n;k++)
       	{
       		for(int i=0;i<n;i++)
       		{
       			for(int j=0;j<n;j++)
       			{
       				if(i==j)continue;
       				g[i][j]=min((long long)g[i][k]+g[k][j],(long long)g[i][j]);
       			}
       		}
       			
       	}
       	int ans = INT_MAX;
       	int idx = 0;
       	for(int i=n-1;i>=0;i--)
       	{
       		int temp=0;
       		for(int j=0;j<n;j++)
       		{
       			if(g[i][j]<=distanceThreshold)
       			{
       				temp+=1;
       			}
       		}
       		if(ans>temp)
       			{
       				ans = temp;
       				idx = i;
       			}
       	}

        return idx;

}
};