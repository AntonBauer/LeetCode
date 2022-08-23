using NUnit.Framework;

namespace ValidParentheses;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestIsValid(string s) => Solution.IsValid(s);

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("()").Returns(true);
        yield return new TestCaseData("()[]{}").Returns(true);
        yield return new TestCaseData("(]").Returns(false);
        yield return new TestCaseData("[").Returns(false);
    }
}