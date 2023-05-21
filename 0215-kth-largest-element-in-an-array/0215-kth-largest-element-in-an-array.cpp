class Solution {
public:
    
int partition(vector<int>&a,int s,int e)
{
	int pivot = a[e];
	int i = s-1;
	for(int j=s;j<e;j++)
	{
		if(pivot<a[j])
		{
			i++;
			swap(a[i],a[j]);
		}
	}
	swap(a[i+1],a[e]);
	return i+1;

}

int quickselect(vector<int>&arr,int s,int e,int k)
{
	int  p = partition(arr,s,e);
	if(p==k)return arr[p];
	else if(p<k){
		return quickselect(arr,p+1,e,k);
	}
	else{
		return quickselect(arr,s,p-1,k);
	}
}

int findKthLargest(vector<int>& nums, int k) {
        int s = 0;
        int e = nums.size()-1;

        return quickselect(nums,s,e,k-1);
    }
};