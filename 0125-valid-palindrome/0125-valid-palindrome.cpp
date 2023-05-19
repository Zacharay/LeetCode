class Solution {
public:
    bool isPalindrome(string s) {
        int p=0;
        int k = s.length();

        while(p<k)
        {
        	if(!isalnum(s[p]))
        	{
        		p++;
        		continue;
        	}
        	if(!isalnum(s[k]))
        	{
        		k--;
        		continue;
        	}
        	
        	if(tolower(s[p])==tolower(s[k]))
        	{
        		p++;
        		k--;
        	}
        	else {
        		return false;
        	}
        }
        return true;
    }
};