using NUnit.Framework;

namespace RansomNote;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestCanConstruct(string ransomNote, string magazine) => Solution.CanConstruct(ransomNote, magazine);
    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("a", "b").Returns(false).SetName("01");
        yield return new TestCaseData("aa", "ab").Returns(false).SetName("02");
        yield return new TestCaseData("aa", "aab").Returns(true).SetName("03");
    }
}