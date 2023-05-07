class Solution {
public:
   
int dfs(vector<vector<int> > &g,pair<int,int> node ,vector<vector<bool> > &visited,int n,int m,int &counter)
{
	
	int x = node.first;
	int y = node.second;
	
	visited[x][y]=1;
	counter++;
	if(x<n-1&&!visited[x+1][y]&&g[x+1][y])
	{
		dfs(g,make_pair(x+1,y),visited,n,m,counter);
	}
	if(x>0&&!visited[x-1][y]&&g[x-1][y])
	{
		dfs(g,{x-1,y},visited,n,m,counter);
	}
	if(y<m-1&&!visited[x][y+1]&&g[x][y+1])
	{
		dfs(g,{x,y+1},visited,n,m,counter);
	}
	if(y>0&&!visited[x][y-1]&&g[x][y-1])
	{
		dfs(g,{x,y-1},visited,n,m,counter);
	}

    return counter;
}

int maxAreaOfIsland(vector<vector<int>> grid)
{
	int n = grid.size();
	int m = grid[0].size();
	vector<vector<bool> > visited(n,vector<bool>(m,0));
	int max_counter=0;
	for(int i=0;i<grid.size();i++)
	{
		for(int j=0;j<grid[i].size();j++)
		{
			if(grid[i][j]==0)continue;
			int counter = 0;
			dfs(grid,{i,j},visited,n,m,counter);
			max_counter = max(counter,max_counter);
		}
	}
	
    return max_counter;

}
};