using System.Diagnostics.CodeAnalysis;

namespace MergeTwoSortedLists;

internal static class Solution
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var firstPointer = list1;
        var secondPointer = list2;

        var resultHead = default(ListNode);
        var resultPointer = default(ListNode);

        while (firstPointer is not null && secondPointer is not null)
        {
            var value = CalculateValue(firstPointer, secondPointer);
            if (resultHead is null)
            {
                resultHead = new ListNode(value);
                resultPointer = resultHead;
            }
            else
            {
                resultPointer.next = new ListNode(value);
                resultPointer = resultPointer.next;
            }
        }

        return resultHead;
    }

    private static int CalculateValue(ListNode? firstPointer, ListNode? secondPointer)
    {
        if (firstPointer == null)
        {
            var value = secondPointer.val;
            secondPointer = secondPointer.next;

            return value;
        }

        if (secondPointer == null)
        {
            var value = firstPointer.val;
            firstPointer = firstPointer.next;

            return value;
        }

        if (firstPointer.val < secondPointer.val)
        {
            var value = firstPointer.val;
            firstPointer = firstPointer.next;

            return value;
        }
        else
        {
            var value = secondPointer.val;
            secondPointer = secondPointer.next;

            return value;
        }
    }
}