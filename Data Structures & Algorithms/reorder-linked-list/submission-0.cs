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
    public void ReorderList(ListNode head) {

        if(head==null || head.next ==null){
            return;
        }

        var slow = head;
        var fast = head;

        while(fast!=null && fast.next!=null){
            slow =slow.next;
            fast = fast.next.next;
        }

        var part = slow.next;
        slow.next = null;

        //reverse
        ListNode prev = null;
        while(part!=null){
            var next = part.next;
            part.next = prev;
            prev = part;
            part = next;
        }

       var first = head;
       var second = prev;

        while(second!=null){
            var temp1= first.next;
            var temp2= second.next;


            first.next = second;
            second.next = temp1;

            first = temp1;
            second  = temp2; 
        }

        
    }
}
