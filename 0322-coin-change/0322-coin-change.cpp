class Solution {
public:
     int coinChange(vector<int>& coins, int amount) {
	const int max_amount = 1e4+10;
	vector<int>tab(max_amount,INT_MAX);

	tab[0]=0;
	for(int i=0;i<coins.size();i++)
	{

		for(int j=0;j<amount;j++)
		{
			if(tab[j]!=INT_MAX)
			{
				int coin = coins[i];
				int prev_val = tab[j]+1;
				if(j+coin>amount)break;
				tab[j+coin] = min(prev_val,tab[j+coin]);
			}
		}

	}
	if(tab[amount]==INT_MAX)return -1;
	return tab[amount];
}
};