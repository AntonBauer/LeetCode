namespace PalindromeLinkedList;

// 234. Palindrome Linked List
internal static class Solution
{
    public static bool IsPalindrome(ListNode head)
    {
        var stack = FillStack(head);

        var current = head;
        while (stack.TryPop(out var value))
        {
            if (value != current.val)
                return false;

            current = current.next;
        }
        
        return true;
    }

    private static Stack<int> FillStack(ListNode head)
    {
        var stack = new Stack<int>();
        var current = head;

        do
        {
            stack.Push(current.val);
            current = current.next;
        } while (current != null);

        return stack;
    }
}