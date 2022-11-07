using NUnit.Framework;

namespace PascalsTriangle;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public IList<IList<int>> TestGenerate(int numRows) => Solution.Generate(numRows);

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(5).Returns(new[] { new[] { 1 }, new[] { 1, 1 }, new[] { 1, 2, 1 }, new[] { 1, 3, 3, 1 }, new[] { 1, 4, 6, 4, 1 } });
        yield return new TestCaseData(1).Returns(new[] { new[] { 1 } });
    }
}