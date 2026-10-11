public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for (int row = 0; row < matrix.Length; row++) {
            for (int col = 0; col < matrix[row].Length; col++) {
                if (matrix[row][col] == target) {
                    return true;
                }
            }
        }
        return false;
    }
}
