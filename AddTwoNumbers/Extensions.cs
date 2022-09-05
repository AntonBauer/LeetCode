namespace AddTwoNumbers;

internal static class Extensions
{
    public static ListNode ToListNode(this int[] array)
    {
        var head = new ListNode(array[^1]);
        for (var i = array.Length - 2; i >= 0; i--)
            head = new ListNode(array[i], head);

        return head;
    }

    public static int[] ToArray(this ListNode list)
    {
        var buffer = new List<int>();
        var head = list;
        
        while (head != null)
        {
            buffer.Add(head.val);
            head = head.next;
        }

        return buffer.ToArray();
    }
}