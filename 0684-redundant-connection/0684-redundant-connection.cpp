class Solution {
public:
    
int find(int a,vector<int>&rep)
{
	if(rep[a]==-1)return a;
	else return find(rep[a],rep);
}
void un(int a,int b,vector<int>&rep)
{
	int s1 = find(a,rep);
    int s2 = find(b,rep);

    if(s1!=s2)
    	rep[s1]=s2;
}
    vector<int> findRedundantConnection(vector<vector<int>>& edges) {
         vector<int>rep(1011,-1);
        vector<int>ans;
        for(int i=0;i<edges.size();i++)
        {
        	int u = edges[i][0];
        	int v = edges[i][1];

        	int s1 = find(u,rep);
        	int s2 = find(v,rep);

        	if(s1==s2)
        	{
        		ans = {u,v};
        	}
        	else{
        		un(u,v,rep);
        	}
        }
    return ans;
    }
};