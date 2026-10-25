public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        Dictionary<char, int> freqMap = new();

        for (int i = 0; i < tasks.Length; i++) {
            if (!freqMap.ContainsKey(tasks[i])) {
                freqMap[tasks[i]] = 0;
            }
            freqMap[tasks[i]]++;
        }

        PriorityQueue<(char task, int freq), int> maxHeap = new();

        foreach (var key in freqMap.Keys) {
            maxHeap.Enqueue((key, freqMap[key]), -freqMap[key]);
        }

        Queue<(char task, int left, int readyAt)> waitingQueue = new();

        int cycle = 0;

        while (maxHeap.Count != 0 || waitingQueue.Count != 0) {
            cycle++;

            if (waitingQueue.Count > 0 && waitingQueue.Peek().readyAt <= cycle) {
                var waitingTask = waitingQueue.Dequeue();
                maxHeap.Enqueue((waitingTask.task, waitingTask.left), -waitingTask.left);
            }

            if (maxHeap.Count > 0) {
                var processedTask = maxHeap.Dequeue();
                if (processedTask.freq - 1 > 0) {
                    waitingQueue.Enqueue(
                        (processedTask.task, processedTask.freq - 1, cycle + n + 1));
                }
            }
        }

        return cycle;
    }
}
