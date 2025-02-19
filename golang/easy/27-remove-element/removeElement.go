package removeElement

func removeElement(nums []int, val int) int {
	if val > 50 {
		return 0
	}

	var delta = 0
	var i = 0

	// set item in current index to currentIndex + delta
	// Incremet delta every time val is encountered
	for i+delta < len(nums) {
		if nums[i] == val {
			delta = delta + 1
		}
	}

	return i + 1
}
