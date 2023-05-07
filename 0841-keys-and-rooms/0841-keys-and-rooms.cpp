class Solution {
public:
    void Dfs(vector<bool>&visited,vector<vector<int>>&rooms ,int node)
{
	visited[node]=1;
	for(auto nbr:rooms[node])
	{
		if(visited[nbr]==0)
			Dfs(visited,rooms,nbr);
	}
}


bool canVisitAllRooms(vector<vector<int>> rooms) {
    vector<bool>visited(rooms.size(),0);
 	Dfs(visited,rooms,0);
 	for(auto v:visited)
 	{
 		if(!v)
 			return false;
 	}
 	return true;
}
};