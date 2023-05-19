class Solution {
public:
   int search(vector<int>& nums, int target) {
        
        int p =0;
        int k = nums.size();
        while(p<k)
        {
        	int mid= (p+k)/2;
        	if(nums[mid]==target)
        		return mid;
        	if(nums[mid]<target)
        	{
        		p = mid+1;
        	}
        	else
        	{
        		k=mid;
        	}
        }
        return -1;
    }

};