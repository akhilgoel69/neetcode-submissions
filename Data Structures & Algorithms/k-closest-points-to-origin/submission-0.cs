public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<(int[] point, int dist), int> maxHeap = new();
        List<int[]> res = new();

        for (int i = 0; i < points.Length; i++) {
            var distance = points[i][0] * points[i][0] + points[i][1] * points[i][1];
            if (maxHeap.Count < k) {
                maxHeap.Enqueue((points[i], distance), -distance);
            } else if (maxHeap.Peek().dist > distance) {
                maxHeap.Dequeue();
                maxHeap.Enqueue((points[i], distance), -distance);
            }
        }

        while (maxHeap.Count > 0) {
            res.Add(maxHeap.Peek().point);
            maxHeap.Dequeue();
        }

        return res.ToArray();
    }
}
