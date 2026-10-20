public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> maxHeap = new();

        for (int i = 0; i < stones.Length; i++) {
            maxHeap.Enqueue(stones[i], -stones[i]);
        }

        while (maxHeap.Count > 1) {
            var stone1 = maxHeap.Dequeue();
            var stone2 = maxHeap.Dequeue();

            if (stone1 != stone2) {
                maxHeap.Enqueue(Math.Abs(stone1 - stone2), -Math.Abs(stone1 - stone2));
            }
        }

        return maxHeap.Count>0 ? maxHeap.Peek():0;
    }
}
