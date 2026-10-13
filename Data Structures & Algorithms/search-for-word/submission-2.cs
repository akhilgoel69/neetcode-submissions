public class Solution {
    public bool Exist(char[][] board, string word) {
        HashSet<(int row, int column)> visited = new();
        for (int row = 0; row < board.Length; row++) {
            for (int col = 0; col < board[row].Length; col++) {
                if (DFS(board, word, 0, row, col, visited)) {
                    return true;
                }
            }
        }
        return false;
    }

    public bool DFS(char[][] board, string word, int index, int row, int col,
                    HashSet<(int row, int column)> visited) {

        if (index == word.Length) {
            return true;
        }
        
        if (row < 0 || row >= board.Length || col < 0 || col >= board[row].Length ||
            visited.Contains((row, col))) {
            return false;
        }

        if (board[row][col] != word[index]) {
            return false;
        }

        visited.Add((row,col));


        var found = DFS(board, word, index + 1, row + 1, col, visited) ||
                    DFS(board, word, index + 1, row - 1, col, visited) ||
                    DFS(board, word, index + 1, row, col + 1, visited) ||
                    DFS(board, word, index + 1, row, col - 1, visited);

        visited.Remove((row,col));

        return found;
    }
}
