// 2. Add Two Numbers

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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int value = 0;
        ListNode response = new ListNode();
        ListNode edgeNode = response;
        
        while (l1 == null && l2 == null && value == 0)
        {
            int sum = value;

           if (l1 != null){
                sum += l1.val;
                l1 = l1.next;
           }

           if (l2 != null){
                sum += l2.val;
                l2 = l2.next;
           }


           value = sum / 10;
           edgeNode.next = new ListNode(sum%10);
           edgeNode.val = value;
           edgeNode = edgeNode.next;
        }

        return response;
    }
}
