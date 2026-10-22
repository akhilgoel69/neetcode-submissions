public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> res = new();
        for (int i = 0; i < intervals.Length; i++) {
            if (newInterval[1] < intervals[i][0])  // Insert Left
            {
                res.Add(newInterval);
                newInterval = intervals[i];
            } else if (intervals[i][1] < newInterval[0])  // Insert Right
            {
                res.Add(intervals[i]);
            } else  // else overlapping
            {
                var start = Math.Min(newInterval[0], intervals[i][0]);
                var end = Math.Max(newInterval[1], intervals[i][1]);

                newInterval = new int[] { start, end };
            }
        }

        // insert newInterval then return intervals array

        res.Add(newInterval);
        return res.ToArray();
    }
}
