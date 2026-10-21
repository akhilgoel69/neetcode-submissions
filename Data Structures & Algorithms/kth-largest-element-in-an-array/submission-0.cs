public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> minHeap = new();

        for (int i = 0; i < nums.Length; i++) {
            if (minHeap.Count < k) {
                minHeap.Enqueue(nums[i], nums[i]);
            } else if (minHeap.Peek() < nums[i]) {
                minHeap.Dequeue();
                minHeap.Enqueue(nums[i], nums[i]);
            }
        }

        return minHeap.Peek();
    }
}
