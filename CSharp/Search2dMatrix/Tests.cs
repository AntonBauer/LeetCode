using NUnit.Framework;

namespace Search2dMatrix;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSearch(int[][] matrix, int target) => Solution.SearchMatrix(matrix, target);

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[]
        {
            new[] { 1, 3, 5, 7 },
            new[] { 10, 11, 16, 20 },
            new[] { 23, 30, 34, 60 }
        }, 3).Returns(true).SetName("01");

        yield return new TestCaseData(new[]
        {
            new[] { 1, 3, 5, 7 },
            new[] { 10, 11, 16, 20 },
            new[] { 23, 30, 34, 60 }
        }, 13).Returns(false).SetName("02");
        
        yield return new TestCaseData(new[]
        {
            new[] { 1, 3, 5 }
        },5).Returns(true).SetName("03");
    }
}