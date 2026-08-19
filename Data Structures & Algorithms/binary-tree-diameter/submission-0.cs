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
    int maxDiameter = Int32.MinValue;

    public int DiameterOfBinaryTree(TreeNode root) {
       MaxDiameter(root);
       return maxDiameter;
    }


    public int MaxDiameter(TreeNode root) {
        if (root == null) {
            return 0;
        }

        var leftDia = MaxDiameter(root.left);
        var rightDia = MaxDiameter(root.right);

        maxDiameter = Math.Max(maxDiameter, leftDia + rightDia);

        return 1 + Math.Max(leftDia, rightDia);
    }
}
