class Solution {
public:
    int orangesRotting(vector<vector<int>>  grid)
{
    int n = grid.size();
    int m = grid[0].size();
    vector<vector<int>>matrix(n,vector<int>(m,-1));
    queue<pair<int,int>>q;
    int fresh=0;
    for(int i=0;i<n;i++)
    {
    	for(int j=0;j<m;j++)
    	{
    		if(grid[i][j]==2)
    		{
    			matrix[i][j]=0;
    			q.push({i,j});
    		}
    		else if(grid[i][j]==1)
    		{
    			fresh++;
    			matrix[i][j]=INT_MAX;
    		}
    	}
    }
    int nx[]={0,0,1,-1};
    int ny[] = {1,-1,0,0};
    while(!q.empty())
    {
    	pair<int,int>f = q.front();
    	q.pop();
    	int i = f.first;
    	int j = f.second;

    	for(int k=0;k<4;k++)
    	{
    		int x = i+nx[k];
    		int y = j + ny[k];
    		if(x>=0&&x<n&&y>=0&&y<m&&matrix[x][y]==INT_MAX)
    		{
    			fresh--;
    			if(fresh==0)
    				return matrix[i][j]+1;
    			else{
    				matrix[x][y]=matrix[i][j]+1;
    				q.push({x,y});
    			}
    		}
    	}
    }
    if(fresh==0)
    	return 0;
    return -1;

}
};