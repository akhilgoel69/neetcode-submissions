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
    public bool IsBalanced(TreeNode root) {
        // BC
        if (root == null) {
            return true;
        }

        var leftH = GetHeight(root.left);
        var rightH = GetHeight(root.right);

        if(Math.Abs(leftH-rightH)>1){
            return false;
        }

        return IsBalanced(root.left) && IsBalanced(root.right);
    }

    public int GetHeight(TreeNode root) {
        if (root == null) {
            return 0;
        }

        var leftHeight = GetHeight(root.left);
        var rightHeight = GetHeight(root.right);

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
