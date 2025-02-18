package validParentheses

type Stack struct {
	items []rune
}

func (s *Stack) Push(char rune) {
	s.items = append(s.items, char)
}

func (s *Stack) Peek() rune {
	return s.items[len(s.items)-1]
}

func (s *Stack) Pop() rune {
	var item = s.items[len(s.items)-1]
	s.items = s.items[:len(s.items)-1]

	return item
}

func (s *Stack) IsEmpty() bool {
	return len(s.items) == 0
}

func isValid(s string) bool {
	stack := Stack{}

	for _, char := range s {
		switch {
		case char == '{' || char == '(' || char == '[':
			stack.Push(char)

		case char == '}':
			last := stack.Pop()
			if last != '{' {
				return false
			}
		case char == ')':
			last := stack.Pop()
			if last != '(' {
				return false
			}
		case char == ']':
			last := stack.Pop()
			if last != '[' {
				return false
			}
		}
	}

	return stack.IsEmpty()
}
