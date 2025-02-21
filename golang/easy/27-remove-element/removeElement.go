package removeElement

func removeElement(nums []int, val int) int {
	if val > 50 {
		return len(nums)
	}

	var delta = 0
	var i = 0

	for i+delta < len(nums) {
		for i+delta < len(nums) && nums[i+delta] == val {
			delta += 1
		}

		if i+delta >= len(nums) {
			break
		}

		nums[i] = nums[i+delta]
		i += 1
	}

	return i
}
