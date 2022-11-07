namespace ValidParentheses;

// 20. Valid Parentheses
internal static class Solution
{
    private enum Parentheses : byte
    {
        Round,
        Squared,
        Curly
    }
    
    public static bool IsValid(string s)
    {
        var parenthesesStack = new Stack<Parentheses>();

        foreach (var symbol in s)
        {
            switch (symbol)
            {
                case '(':
                    parenthesesStack.Push(Parentheses.Round);
                    break;
                case ')':
                    if (!CheckPop(parenthesesStack, Parentheses.Round))
                        return false;
                    break;
                
                case '[':
                    parenthesesStack.Push(Parentheses.Squared);
                    break;
                case ']':
                    if (!CheckPop(parenthesesStack, Parentheses.Squared))
                        return false;
                    break;
                
                case '{':
                    parenthesesStack.Push(Parentheses.Curly);
                    break;
                case '}':
                    if (!CheckPop(parenthesesStack, Parentheses.Curly))
                        return false;
                    break;
            }
        }
            
        return !parenthesesStack.Any();
    }

    private static bool CheckPop(Stack<Parentheses> stack, Parentheses expected)
    {
        if (!stack.TryPop(out var actual))
            return false;

        return actual == expected;
    }
}