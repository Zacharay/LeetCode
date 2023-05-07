class Solution {
public:
    int findCenter(vector<vector<int>>edges)
{
    int a1 = edges[0][0];
    int b1 = edges[0][1];

    int a2 = edges[1][0];
    int b2 = edges[1][1];

    if(a1==a2||a1==b2)
    	return a1;
    if(b1==a2||b1==b2)
    	return b1;

    return -1;
     
}
};