class Solution {
public:
    bool isAnagram(string s, string t) {
	int tab[26]{0};

	for(int i=0;i<s.length();i++)
	{
		int idx = (int)s[i]-97;
		tab[idx]++;
	}
	for(int i=0;i<t.length();i++)
	{
		int idx = (int)t[i]-97;
		tab[idx]--;
	}

	for(int i=0;i<26;i++)
	{
		if(tab[i]!=0)return false;
	}

	return true;
}
};