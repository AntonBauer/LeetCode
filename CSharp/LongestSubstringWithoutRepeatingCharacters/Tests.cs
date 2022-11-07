using NUnit.Framework;

namespace LongestSubstringWithoutRepeatingCharacters;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public int TestLengthOfLongestSubstring(string s) => Solution.LengthOfLongestSubstring(s);
    
    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData("abcabcbb").Returns(3).SetName("01");
        yield return new TestCaseData("bbbbb").Returns(1).SetName("02");
        yield return new TestCaseData("pwwkew").Returns(3).SetName("03");
    }
}