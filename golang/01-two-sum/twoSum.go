package twosum

func TwoSum(nums []int, target int) []int {
	diffsMap := make(map[int]int)

	for i, value := range nums {
		diff := target - value

		elem, isDiffPresent := diffsMap[value]

		if isDiffPresent {
			return []int{elem, i}
		} else {
			diffsMap[diff] = i
		}
	}

	return []int{}
}
