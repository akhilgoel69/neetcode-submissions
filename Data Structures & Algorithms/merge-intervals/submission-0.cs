public class Solution {
    public int[][] Merge(int[][] intervals) {
        List<int[]> res = new();

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        res.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++) {
            var current = intervals[i];

            var prev = res[res.Count - 1];

            if (prev[1] >= current[0]) {
                var start = Math.Min(prev[0], current[0]);
                var end = Math.Max(prev[1], current[1]);
                res.RemoveAt(res.Count - 1);
                res.Add(new int[] { start, end });
            }
            else{
                res.Add(intervals[i]);
            }
        }

        return res.ToArray();
        ;
    }
}
