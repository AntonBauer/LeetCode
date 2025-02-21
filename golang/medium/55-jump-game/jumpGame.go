package jumpGame

func canJump(nums []int) bool {
	if len(nums) == 1 {
		return true
	}

	return canJumpFrom(0, nums)
}

func canJumpFrom(currentPosition int, nums []int) bool {
	if currentPosition == len(nums)-1 {
		return true
	}

	if nums[currentPosition] == 0 {
		return false
	}

	if currentPosition+nums[currentPosition] >= len(nums)-1 {
		return true
	}

	for i := currentPosition + nums[currentPosition]; i > 0; i -= 1 {
		if canJumpFrom(i, nums) {
			return true
		}
	}

	return false
}
