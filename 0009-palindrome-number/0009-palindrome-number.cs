public class Solution
{
	public bool IsPalindrome(int x)
	{
		if (x < 0)
		{
			return false;
		}
		string number = x.ToString();
		for (int i = 0; i < number.Length / 2; i++)
		{
			if (number[i] != number[number.Length - 1 - i])
			{
				return false;
			}
		}
		return true;
	}
}