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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> res = null;
        if (root == null) {
            return new List<List<int>>();
        }
        res = new();

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            var count = queue.Count;
            var list = new List<int>();
            for (int i = 0; i < count; i++) {
                var current = queue.Dequeue();
                list.Add(current.val);
                if (current.left != null) {
                    queue.Enqueue(current.left);
                }
                if (current.right != null) {
                    queue.Enqueue(current.right);
                }
            }
            res.Add(new List<int>(list));
        }
        return res;
    }
}
