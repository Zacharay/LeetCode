public class Solution {
    public void SolveSudoku(char[][] board)
	{
		solve(board);

	}
	public bool solve(char[][] board)
	{

		for (int i = 0; i < board.Length; i++)
		{
			for (int j = 0; j < board[i].Length; j++)
			{
				if (board[i][j] == '.')
				{
					bool[] legalNums = generateLegalNumbers(j, i, board);
					
					for (int k = 1; k <= 9; k++)
					{
						if (legalNums[k] == true)
						{
							board[i][j] = Convert.ToChar('0'+k);
							if (solve(board))
								return true;

							board[i][j] = '.';
						}

					}
					return false;
				}
				
			}
		}
		return true;
	}
	public bool[] generateLegalNumbers(int cellX,int cellY, char[][] board)
	{
		bool[] isNumLegal = new bool[10];
		for (int i = 0; i < 10; i++)
			isNumLegal[i] = true;


		//horizontal
		for(int i=0;i<9;i++)
		{
			char horizontalNum = board[cellY][i];
			char verticalNum = board[i][cellX];

			if (horizontalNum != '.')
			{
				int idx = horizontalNum - '0';
				isNumLegal[idx] = false;
			}
			if (verticalNum != '.')
			{
				int idx = verticalNum - '0';
				isNumLegal[idx] = false;
			}
		}
		//vertical

		int startingX = (cellX / 3)*3;
		int startingY = (cellY / 3)*3;
		//3x3
		for(int i=0;i<3;i++)
		{
			for(int j=0;j<3;j++)
			{
				char boxNum = board[startingY + i][startingX + j];

				if (boxNum == '.') continue;

				int idx = boxNum - '0';
				isNumLegal[idx] = false;
			}
		}


		return isNumLegal;
	}
}