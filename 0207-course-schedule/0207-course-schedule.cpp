class Solution {
public:
    void topologicalSort(vector<int>g[],vector<int>&dep)
{
	queue<int>q;
	for(int i=0;i<dep.size();i++)
	{
		if(dep[i]==0)
		{
			q.push(i);
		}
	}
	while(!q.empty())
	{
		int f = q.front();
		q.pop();
		for(auto nbr:g[f])
		{
			dep[nbr]--;
			if(dep[nbr]==0)
			{
				q.push(nbr);
			}
		}
	}
}
    bool canFinish(int numCourses, vector<vector<int>>& prerequisites) {
         vector<int>graph[numCourses+1];
        vector<int>dep(numCourses+1,0);
        for(int i=0;i<prerequisites.size();i++)
        {
            int a= prerequisites[i][0];
            int b = prerequisites[i][1];
            graph[b].push_back(a);
            dep[a]++;
        }
        topologicalSort(graph,dep);
        for(int i=0;i<dep.size();i++)
        {
            if(dep[i]!=0)
                return false;
        }
        return true;
    }
};