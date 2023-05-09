class Solution {
public:
    int networkDelayTime(vector<vector<int>> times, int n, int k) {
	vector<pair<int,int>>*g;
	g = new vector<pair<int,int>>[n+1];
	for(int i=0;i<times.size();i++)
	{
		int a = times[i][0];
		int b = times[i][1];
		int wt = times[i][2];
		g[a].push_back({b,wt});
	}
	vector<int>dist(n+1,INT_MAX);
	set<pair<int,int>>s;
	int ans = 0;
	s.insert({0,k});
	dist[k]=0;
	while(!s.empty())
	{
		pair<int,int> f = *s.begin();
		s.erase(s.begin());
		for(auto x:g[f.second])
		{
			if(dist[x.first]>dist[f.second]+x.second)
			{
				dist[x.first]=dist[f.second]+x.second;
				s.insert({x.second,x.first});
			}
		}
	}
	for(int i=1;i<=n;i++)
	{
		if(dist[i]==INT_MAX)return -1;
		ans = max(ans,dist[i]);
	}
	return ans;
}
};