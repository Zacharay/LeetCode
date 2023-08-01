/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
        int remainder = 0 ;
        int carry = 0;
		int sum = l1.val + l2.val + carry;
		l1 = l1.next;
		l2 = l2.next;
		remainder = sum % 10;
		carry = sum / 10;
		ListNode head = new ListNode(remainder, null);

        ListNode currentNode = head;
        while(l1 != null||l2!=null)
        {
            l1 = l1 == null ? new ListNode(0, null) : l1;
            l2 = l2 == null ? new ListNode(0, null) : l2;

            sum = l1.val+l2.val+carry;
            l1 = l1.next;
            l2 = l2.next;
            remainder = sum % 10;
            carry = sum / 10;

            ListNode temp = new ListNode(remainder,null);
            currentNode.next = temp;
            currentNode = temp;

        }
        if(carry!=0)
        {
            currentNode.next = new ListNode(carry, null);
        }
        //ReverseLinkedList(ref head);
        return head;
	}
}