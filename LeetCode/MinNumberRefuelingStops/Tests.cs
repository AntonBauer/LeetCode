using NUnit.Framework;

namespace MinNumberRefuelingStops;

[TestFixture]
public class Tests
{
    [Test]
    [TestCaseSource(nameof(TestCases))]
    public int TestRefuelingStops(int target, int startFuel, int[][] stations) =>
        Solution.MinRefuelStops(target, startFuel, stations);

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(1, 1, Array.Empty<int[]>()).Returns(0);
        yield return new TestCaseData(100, 1, new[] { new[] { 10, 100 } }).Returns(-1);
        yield return new TestCaseData(100, 10,
            new[] { new[] { 10, 60 }, new[] { 20, 30 }, new[] { 30, 30 }, new[] { 60, 40 } }).Returns(2);
        yield return new TestCaseData(100, 50, new[] { new[] { 25, 50 }, new[] { 50, 25 } }).Returns(1);
        yield return new TestCaseData(1000, 299,
            new[]
            {
                new[] { 13, 21 }, new[] { 26, 115 }, new[] { 100, 47 }, new[] { 225, 99 }, new[] { 299, 141 },
                new[] { 444, 198 }, new[] { 608, 190 }, new[] { 636, 157 }, new[] { 647, 255 }, new[] { 841, 123 }
            }).Returns(4);
    }
}