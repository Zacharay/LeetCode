public class Solution {
    public struct Vector2
	{
		public int row;
		public int col;
	}
	public int UniquePathsIII(int[][] grid)
	{
		int n = grid.Length;
		int m = grid[0].Length;
		int numOfObstacles = 0;
		Vector2 startingCoords= new Vector2();
		Vector2 destCoords = new Vector2();

		for(int i=0;i< n; i++)
			for(int j = 0; j < m; j++)
			{
				if (grid[i][j] == 0)continue; 
				else if (grid[i][j] == 1)
				{
					startingCoords = new Vector2{ row =i,col=j};
				}
				else if (grid[i][j] == 2)
				{
					destCoords = new Vector2 { row = i, col = j };
				}
				else numOfObstacles++;
			}

		int desiredPathLength = n * m - 1 - numOfObstacles;
		Console.WriteLine(desiredPathLength);
		int[,] visited = new int[n, m];
		for(int i=0;i<n;i++)
		{
			for(int j=0;j<m;j++)
			{
				visited[i, j] = 0;
			}
		}
		int numOfPathsFound = 0;
		dfs(startingCoords, destCoords, n, m, grid, visited, 0, desiredPathLength, ref numOfPathsFound);
		return numOfPathsFound;
	}
	public void dfs(Vector2 currentSq,Vector2 destSq,int n,int m,int[][] grid,int[,] visited,int pathLength,
		int desiredPathLength,ref int numOfPathsFound)
	{
		/*if (currentSq.row == 2 && currentSq.col == 2)
		{
			Console.WriteLine(currentSq.col + " " + currentSq.row+" "+pathLength);
		}*/


		visited[currentSq.row,currentSq.col] = 1;
		if(currentSq.row==destSq.row&&currentSq.col==destSq.col&&pathLength==desiredPathLength)
		{
			
			numOfPathsFound++;
			visited[currentSq.row, currentSq.col] = 0;
			return;
		}
		pathLength++;

		int[] dx = { 0, 0, -1, 1 };
		int[] dy = { 1, -1, 0, 0 };
		for(int k=0;k<4;k++)
		{
			int x = currentSq.col + dx[k];
			int y = currentSq.row + dy[k];
			
			if (x>=0 && y>=0 && x < m && y < n && visited[y, x] == 0 && grid[y][x] != -1 && grid[y][x]!=1)
			{
				//if(x==2&&y==2)Console.WriteLine(x + " " +y);

				dfs(new Vector2 { row = y, col = x }, destSq, n, m, grid, visited, pathLength, desiredPathLength,ref numOfPathsFound);
			}
		}
		visited[currentSq.row, currentSq.col] = 0;
	}
}