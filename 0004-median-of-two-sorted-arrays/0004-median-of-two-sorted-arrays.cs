public class Solution {
   public double FindMedianSortedArrays(int[] nums1, int[] nums2)
	{
		double median = 0;
		int n = nums1.Length;
		int m = nums2.Length;

		int i = 0;
		int j = 0;

		int el1 = -1;
		int el2 = -1;

		for(int count =0; count <= (m+n)/2; count++)
		{
			el2 = el1;
			if(i!=n&&j!=m)
			{
				el1 = (nums1[i] < nums2[j]) ? nums1[i++] : nums2[j++];
			}
			else if(i<n)
			{
				el1 = nums1[i++];
			}
			else
			{
				el1 = nums2[j++];
			}
		}
		if ((m + n) % 2 == 0)
		{
			median = (double)(el1 + el2) / 2;
		}
		else median = el1;


		return median;
	}
}