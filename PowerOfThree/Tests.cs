using NUnit.Framework;

namespace PowerOfThree;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestIsPowerOfThree(int n) => Solution.IsPowerOfThree(n);

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(27).Returns(true);
        yield return new TestCaseData(0).Returns(false);
        yield return new TestCaseData(9).Returns(true);
        yield return new TestCaseData(243).Returns(true);
        yield return new TestCaseData(59049).Returns(true);
    }
}