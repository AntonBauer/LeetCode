package jumpGame

var isVisited map[int]bool

func canJump(nums []int) bool {
	isVisited = make(map[int]bool)

	if len(nums) == 1 {
		return true
	}

	return canJumpFrom(0, nums)
}

func canJumpFrom(currentPosition int, nums []int) bool {
	var _, contains = isVisited[currentPosition]
	if contains {
		return false
	}

	if currentPosition == len(nums)-1 {
		return true
	}

	if currentPosition+nums[currentPosition] >= len(nums)-1 {
		return true
	}

	if nums[currentPosition] == 0 {
		isVisited[currentPosition] = true
		return false
	}

	for i := currentPosition + nums[currentPosition]; i > 0; i -= 1 {
		if canJumpFrom(i, nums) {
			return true
		}
	}

	isVisited[currentPosition] = true
	return false
}
