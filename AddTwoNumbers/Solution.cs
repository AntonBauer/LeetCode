namespace AddTwoNumbers;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

// 2. Add Two Numbers
internal static class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var hasOverflow = false;
        ListNode sumHead = default;
        var sumTail = sumHead;
        var first = l1;
        var second = l2;

        do
        {
            (var sum, hasOverflow) = Sum(first?.val ?? 0, second?.val ?? 0, hasOverflow);
            (sumHead, sumTail) = AddToList(sumHead, sumTail, sum);

            first = first?.next;
            second = second?.next;
        } while (!IsAtEnd(first, second));

        if (hasOverflow)
            sumTail.next = new ListNode(1);
        
        return sumHead;
    }

    private static (int sum, bool hasOverflow) Sum(int s1, int s2, bool withOverflow)
    {
        var sum = withOverflow
            ? s1 + s2 + 1
            : s1 + s2;
        
        var hasOverflow = sum > 9;
        
        var corrected = hasOverflow
            ? sum - 10
            : sum;

        return (corrected, hasOverflow);
    }

    private static (ListNode head, ListNode tail) AddToList(ListNode head, ListNode tail, int sum)
    {
        if (head == default)
        {
            head = new ListNode(sum);
            tail = head;
        }
        else
        {
            tail.next = new ListNode(sum);
            tail = tail.next;
        }

        return (head, tail);
    }

    private static bool IsAtEnd(ListNode first, ListNode second) => first == null && second == null;
}