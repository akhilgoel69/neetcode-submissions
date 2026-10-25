public class KthLargest {
    int k = 0;
    PriorityQueue<int,int> minHeap = null;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        minHeap = new();

        for (int i = 0; i < nums.Length; i++) {
            if (minHeap.Count < k) {
                minHeap.Enqueue(nums[i], nums[i]);
            } else if (minHeap.Count > 0 && minHeap.Peek() < nums[i]) {
                minHeap.Dequeue();
                minHeap.Enqueue(nums[i], nums[i]);
            }
        }
    }

    public int Add(int val) {
        if (minHeap.Count < k) {
            minHeap.Enqueue(val, val);
        } else if (minHeap.Count > 0 && minHeap.Peek() < val) {
            minHeap.Dequeue();
            minHeap.Enqueue(val,val);
        }
        return minHeap.Peek();
    }
}
