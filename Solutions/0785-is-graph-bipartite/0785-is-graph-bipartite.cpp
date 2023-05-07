class Solution {
public:
    bool Bfs(int src, vector<vector<int>> graph,vector<int>&color)
{
	queue<int>q;
    q.push(src);
    color[src]=1;
   	while(!q.empty())
   	{
   		int f = q.front();
   		q.pop();
   		for(int nbr : graph[f])
   		{
   			if(color[nbr]==color[f])
   				return false;
   			if(color[nbr]==0)
   			{
   				if(color[f]==1){
   					color[nbr]=2;
   					q.push(nbr);
   				}
   				else{
   					color[nbr]=1;
   					q.push(nbr);
   				}
   			}
   		}
   	}
   	return true;
}

bool isBipartite(vector<vector<int>> graph){
    
    for(int i=0;i<graph.size();i++)
    {
    	for(int nbr:graph[i])
    		cout<<nbr<<" ";

    	cout<<endl;
    }
    vector<int>color(100,0);
   	for(int i=0;i<graph.size();i++)
   	{
   		if(color[i]!=0)continue;
   		if(!Bfs(i,graph,color))
   			return false;
   	}
   	return true;
}
};