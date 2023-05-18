class Solution {
public:
    int climbStairs(int n) {
	vector<long long>tab(50,0);
	tab[0]=1;
 	for(int i=0;i<=n;i++)
 	{
 		tab[i+1]+= tab[i];
 		tab[i+2]+=tab[i];
 	}      	
 	return tab[n];
}
};