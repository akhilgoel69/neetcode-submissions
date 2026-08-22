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
    int maxSum = Int32.MinValue;
    public int MaxPathSum(TreeNode root) {
        MaxPathSumX(root);
        return maxSum;

    }
    public int MaxPathSumX(TreeNode root) {
        if (root == null) {
            return 0;
        }

        var left = Math.Max(0, MaxPathSumX(root.left));
        var right = Math.Max(0,MaxPathSumX(root.right));

        maxSum = Math.Max(maxSum, root.val+ left + right);

        return root.val + Math.Max(left, right);
    }
}
