package twosum

import (
	"reflect"
	"testing"
)

func TestOne(t *testing.T) {
	// Arrange
	nums := []int{2, 7, 11, 15}
	target := 9
	expected := []int{0, 1}

	// Act
	actual := TwoSum(nums, target)

	// Assert
	if !reflect.DeepEqual(actual, expected) {
		t.Fatalf("Actual and expected are not equal")
	}
}

func TestTwo(t *testing.T) {
	// Arrange
	nums := []int{3, 2, 4}
	target := 6
	expected := []int{1, 2}

	// Act
	actual := TwoSum(nums, target)

	// Assert
	if !reflect.DeepEqual(actual, expected) {
		t.Fatalf("Actual and expected are not equal")
	}
}

func TestThree(t *testing.T) {
	// Arrange
	nums := []int{3, 3}
	target := 6
	expected := []int{0, 1}

	// Act
	actual := TwoSum(nums, target)

	// Assert
	if !reflect.DeepEqual(actual, expected) {
		t.Fatalf("Actual and expected are not equal")
	}
}
