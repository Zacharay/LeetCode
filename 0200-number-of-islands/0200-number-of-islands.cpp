class Solution {
public:
    void Bfs(vector<vector<char>>grid,vector<vector<bool>>&visited,int x,int y)
{
	int n = grid.size();
	int m = grid[0].size();	
	queue<pair<int,int>>q;
	q.push({x,y});
	visited[x][y]=1;
	int nx[] = {1,-1,0,0}; 
	int ny[] = {0,0,1,-1}; 
	while(!q.empty())
	{
		pair<int,int>f =q.front();
		q.pop();
		int i = f.first;
		int j = f.second;
		for(int k=0;k<4;k++)
		{
			int x = i + nx[k];
			int y = j + ny[k];
			if(x>=0&&x<n&&y>=0&&y<m&&grid[x][y]=='1'&&!visited[x][y])
			{
				visited[x][y]=1;
				q.push({x,y});
			}
		}
	}
}

int numIslands( vector<vector<char>> grid)
{
	int n = grid.size();
	int m = grid[0].size();
	vector<vector<bool>>visited(n,vector<bool>(m,false));
	int ans = 0;
	for(int i=0;i<n;i++)
	{
		for(int j=0;j<m;j++)
		{
			if(grid[i][j]=='1'&&!visited[i][j])
			{
				Bfs(grid,visited,i,j);
				ans++;
			}
		}
	}
    return ans;
}

};