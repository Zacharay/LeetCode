class Solution {
public:
    bool canJump(vector<int>& nums) {
    int n = nums.size();
    vector<int>tab(n,0);
    tab[0]=1;
    for(int i=0;i<nums.size();i++)
    {
    	if(tab[i])
    	{
    		for(int j=nums[i];j>0;j--)
    		{
    			if(i+j<n)
    			{
    				tab[i+j]++;
    			}
    		}
    	}
    }
    /*for(int i=0;i<tab.size();i++)
    {
    	cout<<tab[i]<<" "; 
    }*/
    if(tab[n-1])
    	return true;
    else 
    	return false;   
   }
};