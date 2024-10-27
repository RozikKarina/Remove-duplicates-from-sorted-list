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
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return head;

        ListNode current = head;

        // Traverse the list
        while (current != null && current.next != null)
        {
            if (current.val == current.next.val)
            {
                // Skip the duplicate
                current.next = current.next.next;
            }
            else
            {
                // Move to the next node
                current = current.next;
            }
        }

        return head;
    }
}