
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new();

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                stack.Push(number);
            }
            else
            {
                int right = stack.Pop();
                int left = stack.Pop();

                switch (token)
                {
                    case "+":
                        stack.Push(left + right);
                        break;

                    case "-":
                        stack.Push(left - right);
                        break;

                    case "*":
                        stack.Push(left * right);
                        break;

                    case "/":
                        stack.Push(left / right);
                        break;
                }
            }
        }

        return stack.Pop();
    }
}
