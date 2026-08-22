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
    int count = 0;
    public int GoodNodes(TreeNode root) {
        var maxVal = Int32.MinValue;
        GoodNodesX(root, maxVal);
        return count;
    }

    public void GoodNodesX(TreeNode root, int maxVal) {
        if (root == null) {
            return;
        }

        if (root.val >= maxVal) {
            count++;
        }

        maxVal = Math.Max(maxVal, root.val);

        GoodNodesX(root.left, maxVal);
        GoodNodesX(root.right, maxVal);
    }
}
