public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        int remove = 0;

        Array.Sort(intervals,(a,b)=>a[1].CompareTo(b[1]));

        var prev = intervals[0];

        for(int i = 1; i < intervals.Length; i++) {
            if (prev[1] > intervals[i][0]) {
                remove++;
            } else {
                prev = intervals[i];
            }
        }

        return remove;
    }
}
