/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    PriorityQueue<int,int> minHeap = new();

    public int KthSmallest(TreeNode root, int k) {
        int res = -1;
        KthSmallestX(root);

        for (int i = 1; i <= k; i++) {
            res = minHeap.Dequeue();
        }

        return res;
    }

    public void KthSmallestX(TreeNode root) {
        if(root==null){
            return;
        }
        minHeap.Enqueue(root.val,root.val);
        KthSmallestX( root.left);
        KthSmallestX( root.right);

    }
}
