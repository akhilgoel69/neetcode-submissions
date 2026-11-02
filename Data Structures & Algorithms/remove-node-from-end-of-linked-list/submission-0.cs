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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int len = 0;

        var p1 = head;

        while (p1 != null) {
            len++;
            p1 = p1.next;
        }

        var removeIndex = len - n;

        int count = 0;
        var current = head;

        var dummy = new ListNode(0);
        dummy.next = head;

        var prev = dummy;
        while (current != null) {
            if (count == removeIndex) {
                prev.next = current.next;
                break;
            }
            prev = current;
            current = current.next;
            count++;
        }

        return dummy.next;
    }
}
