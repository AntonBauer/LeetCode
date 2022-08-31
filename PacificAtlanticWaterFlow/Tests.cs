using NUnit.Framework;

namespace PacificAtlanticWaterFlow;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public void TestPacificAtlantic(List<int[]> heights, List<int[]> expected)
    {
        // Act
        var actual = Solution.PacificAtlantic(heights.ToArray());

        // Assert
        CollectionAssert.AreEquivalent(actual, expected);
    }

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[]
            {
                new[] { 1, 2, 2, 3, 5 },
                new[] { 3, 2, 3, 4, 4 },
                new[] { 2, 4, 5, 3, 1 },
                new[] { 6, 7, 1, 4, 5 },
                new[] { 5, 1, 1, 2, 4 }
            }.ToList(),
            new[]
            {
                new[] { 0, 4 }, new[] { 1, 3 },
                new[] { 1, 4 }, new[] { 2, 2 },
                new[] { 3, 0 }, new[] { 3, 1 },
                new[] { 4, 0 }
            }.ToList()).SetName("01");

        yield return new TestCaseData(new[]
            {
                new[] { 1 }
            }.ToList(),
            new[]
            {
                new[] { 0, 0 }
            }.ToList()).SetName("02");
    }
}