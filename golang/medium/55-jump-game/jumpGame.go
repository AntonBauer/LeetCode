package jumpGame

func canJump(nums []int) bool {
	canReachEnd := make(map[int]bool)
	canReachEnd[len(nums)-1] = true // last item in array can reach itself

	for i := len(nums) - 2; i >= 0; i -= 1 {
		for destination := min(len(nums)-1, i+nums[i]); destination > 0; destination -= 1 {
			if canReachEnd[destination] {
				canReachEnd[i] = true
				break
			}
			canReachEnd[i] = false
		}
	}

	return canReachEnd[0]
}

func min(num1, num2 int) int {
	if num1 < num2 {
		return num1
	} else {
		return num2
	}
}
