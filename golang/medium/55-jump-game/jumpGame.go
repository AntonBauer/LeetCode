package jumpGame

func canJump(nums []int) bool {
	longestJump := 0

	for position, length := range nums {
		if position == len(nums)-1 {
			return true
		}
		longestJump = max(longestJump, position+length)
		if position >= longestJump {
			return false
		}
	}

	return false
}

func max(first, second int) int {
	if first >= second {
		return first
	} else {
		return second
	}
}
