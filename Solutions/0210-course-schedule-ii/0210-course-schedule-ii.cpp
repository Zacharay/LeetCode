class Solution {
public:
 vector<int> topologicalSort(vector<int>g[],vector<int>&dep)
{
    vector<int>res;
	multiset<int>s;
	for(int i=0;i<dep.size();i++)
	{
		if(dep[i]==0)
		{
			s.insert(i);
		}
	}
	while(!s.empty())
	{
		int f = *s.begin();
		s.erase(s.begin());
		res.push_back(f);
		for(auto nbr:g[f])
		{
			dep[nbr]--;
			if(dep[nbr]==0)
			{
				s.insert(nbr);
			}
		}
	}
	res.pop_back();
	return res;
}

int visited[2001];//0 not visited 1 in stack 2 visited not in stack

bool dfs(vector<int> g[],int node)
{

	visited[node]=1;
	for(auto x:g[node])
	{
		if(visited[x]==0&&dfs(g,x))
			return true;
		if(visited[x]==1)
			return true;
	}
	visited[node]=2;
	return false;
}


vector<int> findOrder(int numCourses, vector<vector<int>> prerequisites) {
    vector<int>g[numCourses+1];
    vector<int>indegree(numCourses+1,0);
    for(int i=0;i<prerequisites.size();i++)
    {
        int a = prerequisites[i][0];
        int b = prerequisites[i][1];
        g[b].push_back(a);
        indegree[a]++;
    }

    for(int i=0;i<numCourses;i++)
    {
    	if(visited[i]==0)
    		{
    			if(dfs(g,i))
    				return {};
    		}
    }
    return topologicalSort(g,indegree);
}
};