package mergeTwoSortedLists

import "leetcode/shared"

func mergeTwoLists(list1 *shared.ListNode, list2 *shared.ListNode) *shared.ListNode {
	switch {
	case list1 == nil && list2 != nil:
		return list2
	case list1 != nil && list2 == nil:
		return list1
	case list1 == nil && list2 == nil:
		return nil
	}

	var current1 = list1
	var current2 = list2

	var head *shared.ListNode

	if current1.Val > current2.Val {
		head = &shared.ListNode{
			Val:  current2.Val,
		}
		current2 = current2.Next
	} else {
		head = &shared.ListNode{
			Val:  current1.Val,
		}
		current1 = current1.Next
	}

	var current = head

	for current1 != nil || current2 != nil {
		switch {
		case current2 == nil || current1.Val < current2.Val:
			current.Next = &shared.ListNode{
				Val:  current1.Val,
			}
			current1 = current1.Next

		case current1 == nil || current1.Val >= current2.Val:
			current.Next = &shared.ListNode{
				Val:  current2.Val,
			}
			current2 = current2.Next
		}
			current = current.Next
	}

	return head
}
