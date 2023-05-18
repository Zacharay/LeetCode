class Solution {
public:
    int minCostClimbingStairs(vector<int>& cost) {
       int n = cost.size();
       vector<int>dp(1007,INT_MAX);
       dp[0]=0;
       dp[1]=0;

       for(int i=0;i<n;i++)
       {
       		if(dp[i]!=INT_MAX)
       		{
       			dp[i+1] = min(dp[i+1],dp[i]+cost[i]);
       			dp[i+2] = min(dp[i+2],dp[i]+cost[i]);
       		}
       }
       // for(int i=1;i<=n+1;i++)
       // {
       // 		cout<<i<<" "<<dp[i]<<" "<<endl;
       // }
       return dp[n];
}

};