/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        if (intervals.Count == 0) {
            return true;
        }

        List<int[]> arrList = new();
        foreach (var item in intervals) {
            arrList.Add(new int[] { item.start, item.end });
        }
        var arr = arrList.ToArray();
        Array.Sort(arr, (a, b) => a[1].CompareTo(b[1]));

        var prev = arr[0];

        for (int i = 1; i < arr.Length; i++) {
            var current = arr[i];

            if (prev[1] > current[0]) {
                return false;
            }
            else{
                prev = current;
            }
        }

        return true;
    }
}
