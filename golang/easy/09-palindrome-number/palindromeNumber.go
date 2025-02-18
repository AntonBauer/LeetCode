package palindromeNumber

func isPalindrome(x int) bool {
	if x < 0 {
		return false
	}

	var reversed = 0
	var original = x

	for x > 0 {
		var mod = x % 10
		reversed = reversed*10 + mod
		x = x / 10
	}

	return reversed == original
}
