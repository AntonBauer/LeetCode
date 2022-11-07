using NUnit.Framework;

namespace RotateImage;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public void Test(int[][] matrix, int[][] expected)
    {
        // Act
        Solution.Rotate(matrix);

        // Assert
        CollectionAssert.AreEqual(matrix, expected);
    }

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { new[] { 7, 4, 1 }, new[] { 8, 5, 2 }, new[] { 9, 6, 3 } }
        );
    }
}