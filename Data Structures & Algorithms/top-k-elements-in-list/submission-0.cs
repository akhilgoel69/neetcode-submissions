public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] res = new int[k];
        Dictionary<int, int> freqMap = new();

        PriorityQueue<(int val, int freq), int> maxHeap = new();

        foreach (var item in nums) {
            if (!freqMap.ContainsKey(item)) {
                freqMap[item] = 0;
            }
            freqMap[item]++;
        }

        foreach (var key in freqMap.Keys) {
            maxHeap.Enqueue((key, freqMap[key]), -freqMap[key]);
        }

        for (int i = 0; i < k; i++) {
            res[i] = maxHeap.Dequeue().val;
        }

        return res;
    }
}
