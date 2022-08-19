// See https://aka.ms/new-console-template for more information

var data = new[] { -2,1,-3,4,-1,2,1,-5,4};
var expected = 6;
var actual = MaxSubArray(data);

Console.WriteLine($"Expected {expected}, Actual {actual}");

// Kadane's algorithm
int MaxSubArray(int[] nums) {
    var localMax = 0;
    var globalMax = int.MinValue;
        
    for(var i = 0; i < nums.Length;  i++) {
        localMax = Math.Max(nums[i], nums[i] + localMax);
        if(localMax > globalMax){
            globalMax = localMax;
        }
    }
        
    return globalMax;
}