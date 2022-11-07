using NUnit.Framework;

namespace NumOfIslands;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public int TestNumOfIslands(List<char[]> grid) => Solution.NumOfIslands(grid.ToArray());

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[]
        {
            new[] { '1', '1', '1', '1', '0' },
            new[] { '1', '1', '0', '1', '0' },
            new[] { '1', '1', '0', '0', '0' },
            new[] { '0', '0', '0', '0', '0' }
        }.ToList()).Returns(1).SetName("01");

        yield return new TestCaseData(new[]
        {
            new[] { '1', '1', '0', '0', '0' },
            new[] { '1', '1', '0', '0', '0' },
            new[] { '0', '0', '1', '0', '0' },
            new[] { '0', '0', '0', '1', '1' }
        }.ToList()).Returns(3).SetName("02");

        yield return new TestCaseData(new[]
        {
            new[] { '1', '1', '1' },
            new[] { '0', '1', '0' },
            new[] { '1', '1', '1' }
        }.ToList()).Returns(1).SetName("03");
        
        yield return new TestCaseData(new[]
        {
            new[] { '1', '0', '1', '1', '1' },
            new[] { '1', '0', '1', '0', '1' },
            new[] { '1', '1', '1', '0', '1' },
        }.ToList()).Returns(1).SetName("04");

    }
}