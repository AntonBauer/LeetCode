package validParentheses

import "testing"

type validParenthesesTestData struct {
	name     string
	input    string
	expected bool
}

var testCases = []validParenthesesTestData{
	{"()", "()", true},
	{"()[]{}", "()[]{}", true},
	{"(]", "(]", false},
	{"([])", "([])", true},
	{"([)]", "([)]", false},
	{"]", "]", false},
}

func TestIsValid(t *testing.T) {
	for _, testCase := range testCases {
		var actual = isValid(testCase.input)
		if actual != testCase.expected {
			t.Errorf(
				"%s failed. Expected %t, got %t",
				testCase.name,
				testCase.expected,
				actual,
			)
		}
	}
}
