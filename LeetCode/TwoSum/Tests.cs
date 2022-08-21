using NUnit.Framework;

namespace TwoSum;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestTwoSum(int[] nums, int target) => Solution.TwoSum(nums, target);

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { 2, 7, 11, 15 }, 9).Returns(new[] { 0, 1 });
        yield return new TestCaseData(new[] { 3, 2, 4 }, 6).Returns(new[] { 1, 2 });
        yield return new TestCaseData(new[] { 3, 3 }, 6).Returns(new[] { 0, 1 });
    }
}