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

// public class Interval {
//     public int start, end;
//     public Interval(int start, int end) {
//         this.start = start;
//         this.end = end;
//     }
// }

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        if (intervals.Count == 0) {
            return 0;
        }
        int maxRooms = 1;

        intervals.Sort((a, b) => a.start.CompareTo(b.start));

        PriorityQueue<Interval, int> minRooms = new();

        minRooms.Enqueue(intervals[0], intervals[0].end);

        for (int i = 1; i < intervals.Count; i++) {
            var current = intervals[i];

            while (minRooms.Count > 0 && minRooms.Peek().end <= current.start) {
                minRooms.Dequeue();
            }
            minRooms.Enqueue(current, current.end);

            maxRooms = Math.Max(maxRooms, minRooms.Count);
        }
        return maxRooms;
    }
}
