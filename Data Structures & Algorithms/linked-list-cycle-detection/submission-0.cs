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
    public bool HasCycle(ListNode head) {
        var p1 = head;
        var p2 = head;

        while (p2 != null && p2.next != null) {
            p2 = p2.next.next;
            p1 = p1.next;

            if (p1 == p2) {
                return true;
            }
        }

        return false;
    }
}
