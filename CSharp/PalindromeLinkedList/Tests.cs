using NUnit.Framework;

namespace PalindromeLinkedList;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestIsPalindrome(ListNode head) => Solution.IsPalindrome(head);

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { 1, 2, 2, 1 }.ToListNode()).Returns(true).SetName("01");
        yield return new TestCaseData(new[] { 1, 2 }.ToListNode()).Returns(false).SetName("02");
    }
}