using NUnit.Framework;

namespace MinNumberRefuelingStops;

[TestFixture]
public class Tests
{
    [Test]
    [TestCaseSource(nameof(TestCases))]
    public int TestRefuelingStops(int target, int startFuel, int[][] stations, int expected) =>
        Solution.MinRefuelStops(target, startFuel, stations);

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(1, 1, Array.Empty<int[]>()).Returns(1);
        yield return new TestCaseData(100, 1, new[] { new[] { 10, 100 } }).Returns(-1);
        yield return new TestCaseData(100, 10,
            new[] { new[] { 10, 60 }, new[] { 20, 30 }, new[] { 30, 30 }, new[] { 60, 40 } }).Returns(2);
        yield return new TestCaseData(100, 50, new[] { new[] { 25, 50 }, new[] { 50, 25 } }).Returns(1);
    }
}