public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
 
        Stack<int> minStack = new();
        int[] res = new int[temperatures.Length];
        for (int i = 0; i < temperatures.Length; i++) {
            res[i] = 0;
        }
        for (int i = 0; i < temperatures.Length; i++) {
            while (minStack.Count > 0 && temperatures[i] > temperatures[minStack.Peek()]) {
                int valIndex = minStack.Pop();
                res[valIndex] = i - valIndex;
            }
            minStack.Push(i);
        }
        return res;
    }
}
