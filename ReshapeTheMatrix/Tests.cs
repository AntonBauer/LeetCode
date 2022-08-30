using NUnit.Framework;

namespace ReshapeTheMatrix;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public int[][] TestReshape(int[][] mat, int r, int c) => Solution.MatrixReshape(mat, r, c);

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 1, 4).Returns(new[] { new[] { 1, 2, 3, 4 } }).SetName("01");
        yield return new TestCaseData(new[] { new[] { 1, 2 }, new[] { 2, 4 } }, 2, 4).Returns(new[] { new[] { 1, 2 }, new[] { 2, 4 } }).SetName("02");
        yield return new TestCaseData(new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 4, 1).Returns(new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 } }).SetName("03");
    }
}