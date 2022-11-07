namespace PalindromeLinkedList;

internal static class ArrayExtensions
{
    public static ListNode ToListNode(this int[] array)
    {
        var head = new ListNode(array[^1]);
        
        for(var i = array.Length - 2; i >= 0; i--)
            head = new ListNode(array[i], head);
        
        return head;
    }
}