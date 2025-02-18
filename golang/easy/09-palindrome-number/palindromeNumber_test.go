package palindromeNumber

import "testing"

type palindromeTestData struct {
	name     string
	input    int
	expected bool
}

var testCases = []palindromeTestData{
	{"121 is palindrome", 121, true},
	{"-121 is not a palindrome", -121, false},
	{"10 is not a palindrome", 10, false},
}

func TestPalindromeNumber(t *testing.T) {
	for _, test := range testCases {
		var actual = isPalindrome(test.input)
		if actual != test.expected {
			t.Errorf(
				"%s failed. Expected %t, got %t",
				test.name,
				test.expected,
				actual,
			)
		}
	}
}
