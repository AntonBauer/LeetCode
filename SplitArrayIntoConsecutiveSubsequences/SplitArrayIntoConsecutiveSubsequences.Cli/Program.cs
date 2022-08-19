// See https://aka.ms/new-console-template for more information

var test_one = new[] { 1, 2, 3, 3, 4, 5 }; 
var test_two = new[] { 1, 2, 3, 3, 4, 4, 5, 5 }; 
var test_three = new[] { 1, 2, 3, 4, 4, 5, };

var out_one = IsPossible(test_one);
var out_two = IsPossible(test_two);
var out_three = IsPossible(test_three);

Console.WriteLine("Hello");

static bool IsPossible(int[] nums)
{
    var sequences = new List<LinkedList<int>>(nums.Length / 3);

    foreach (var value in nums)
    {
        var seqToAppend = sequences.LastOrDefault(s => s.Last is not null && s.Last?.Value + 1 == value);
        if (seqToAppend is null)
        {
            sequences.Add(new LinkedList<int>(new[] { value }));
            continue;
        }

        seqToAppend.AddLast(value);
    }
    
    return sequences.All(s => s.Count >= 3);
}