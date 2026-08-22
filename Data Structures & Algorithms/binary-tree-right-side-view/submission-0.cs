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
    public List<int> RightSideView(TreeNode root) {
        List<int> res = new();

        Queue<TreeNode> queue = new();

        if (root != null) {
            queue.Enqueue(root);
        }

        while (queue.Count > 0) {

            var count = queue.Count;

            for(int i=1;i<=count;i++){

                var current  = queue.Dequeue();

                if(i==count){
                    res.Add(current.val);
                }

                if(current.left!=null){
                    queue.Enqueue(current.left);
                }

                if(current.right!=null){
                    queue.Enqueue(current.right);
                }
            }
        }
        return res;
    }
}
