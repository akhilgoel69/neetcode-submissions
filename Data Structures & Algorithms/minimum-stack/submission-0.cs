public class MinStack {
    Stack<int> stack = null;
    Stack<int> minStack = null;

    public MinStack() {
        stack = new();
        minStack = new();
    }

    public void Push(int val) {
        if (minStack.Count == 0 || val < minStack.Peek()) {
            minStack.Push(val);
        } else {
            minStack.Push(minStack.Peek());
        }
        stack.Push(val);
    }

    public void Pop() {
        minStack.Pop();
        stack.Pop();
    }

    public int Top() {
        return stack.Peek();
    }

    public int GetMin() {
        return minStack.Peek();
    }
}
