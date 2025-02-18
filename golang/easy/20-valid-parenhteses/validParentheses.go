package validParentheses

func isValid(s string) bool {
	var counter = make(map[byte]int)

	for _, character := range s {
		var encoded = encode(character)

		count, contains := counter[encoded]

		if contains {
			if shouldAdd(character) {
				count = count + 1
			} else {
				count = count - 1
			}
		} else {
			count = 1
		}

		counter[encoded] = count
	}

	return areAllValuesZero(counter)
}

func encode(parenthesis rune) byte {
	switch {
	case parenthesis == '{' || parenthesis == '}':
		return 0
	case parenthesis == '(' || parenthesis == ')':
		return 1
	case parenthesis == '[' || parenthesis == ']':
		return 2
	}

	return 255
}

func shouldAdd(parenthesis rune) bool {
	return parenthesis == '{' || parenthesis == '(' || parenthesis == '['
}

func areAllValuesZero(counter map[byte]int) bool {
	for _, value := range counter {
		if value != 0 {
			return false
		}
	}

	return true
}
