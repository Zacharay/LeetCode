public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
	{
        int n = obstacleGrid.Length; ;
        int m = obstacleGrid[0].Length;

        if (n == 1 && m == 1)
        {
            return obstacleGrid[0][0] == 1 ? 0 : 1;
        };

        int[,] grid = new int[n, m];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                   grid[i, j] = 0;


        grid[0, 0] = obstacleGrid[0][0] == 1 ? 0 : 1;

        for(int i=1;i<m;i++)
        {
            if (obstacleGrid[0][i] == 1) break;
            grid[0, i] = grid[0, i-1];
        }

		for (int i = 1; i < n; i++)
		{
			if (obstacleGrid[i][0] == 1) break;
			grid[i, 0] = grid[i-1, 0];
		}

        for(int i=1;i<n;i++)
        {
            for(int j=1;j<m;j++)
            {
                if (obstacleGrid[i][j] == 1) continue;

                grid[i, j] = grid[i - 1, j] + grid[i, j - 1];
            }
        }

        return grid[n - 1, m - 1];

	}
}