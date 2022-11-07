using NUnit.Framework;

namespace AddTwoNumbers;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestAddTwoNumbers(int[] first, int[] second) =>
        Solution.AddTwoNumbers(first.ToListNode(), second.ToListNode()).ToArray();

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }).Returns(new[] { 7, 0, 8 }).SetName("01");
        yield return new TestCaseData(new[] { 0 }, new[] { 0 }).Returns(new[] { 0 }).SetName("02");
        yield return new TestCaseData(new[] { 9,9,9,9,9,9,9 }, new[] { 9,9,9,9 }).Returns(new[] { 8,9,9,9,0,0,0,1 }).SetName("03");
    }
}