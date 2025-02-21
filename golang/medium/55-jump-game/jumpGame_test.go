package jumpGame

import "testing"

type JumpTestCase struct {
	name     string
	input    []int
	expected bool
}

var testCases = []JumpTestCase{
	{"[2,3,1,1,4]", []int{2, 3, 1, 1, 4}, true},
	{"[3,2,1,0,4]", []int{3, 2, 1, 0, 4}, false},
	{"[[2,5,0,0]", []int{2, 5, 0, 0}, false},
}

func TestJumpGame(t *testing.T) {
	for _, testCase := range testCases {
		var actual = canJump(testCase.input)
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
