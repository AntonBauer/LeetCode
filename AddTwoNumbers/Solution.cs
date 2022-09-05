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
            var s1 = first?.val ?? 0;
            var s2 = second?.val ?? 0;

            var sum = hasOverflow
                ? s1 + s2 + 1
                : s1 + s2;
            var corrected = sum > 9
                ? sum - 10
                : sum;

            hasOverflow = sum > 9;

            if (sumHead == default)
            {
                sumHead = new ListNode(corrected);
                sumTail = sumHead;
            }
            else
            {
                sumTail.next = new ListNode(corrected);
                sumTail = sumTail.next;
            }

            first = first?.next;
            second = second?.next;
        } while (first != null && second != null);

        if (hasOverflow)
            sumTail.next = new ListNode(1);
        
        return sumHead;
    }
}