class Solution {
public:
    int jump(vector<int>& nums) {
      int n = nums.size();

      const int max_num = 1e4+10;
      vector<int>dp(max_num,INT_MAX);
      dp[0]=0;

      for(int i=0;i<n;i++)
      {
      		if(dp[i]!=INT_MAX)
      		{
      			for(int j=1;j<=nums[i];j++)
      			{
      				if(i+j>n)break;
      				dp[i+j] = min(dp[i+j],dp[i]+1);
      			}
      		}
      }
      return dp[n-1];
}
};