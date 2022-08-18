// See https://aka.ms/new-console-template for more information

Console.WriteLine("1338. Reduce array size in half");
var test = new[] { 3, 3, 3, 3, 5, 5, 5, 2, 2, 7 };
var output = MinSetSize(test);

Console.WriteLine($"To delete count: {output}");

static int MinSetSize(int[] arr)
{
    var hashMap = FillHashMap(arr);
    var counts = ExtractCounts(hashMap);
    return DetermineToDeleteCount(counts, arr.Length / 2);
}

static Dictionary<int, int> FillHashMap(int[] arr)
{
    var dict = new Dictionary<int, int>();
    foreach (var num in arr)
    {
        if (!dict.ContainsKey(num))
            dict.Add(num, 0);

        dict[num]++;
    }

    return dict;
}

static IEnumerable<int> ExtractCounts(Dictionary<int, int> countsHash) => countsHash.Values.OrderByDescending(v => v);

static int DetermineToDeleteCount(IEnumerable<int> counts, int lengthToBeat)
{
    var sum = 0;
    var overallCount = 0;
    foreach (var count in counts)
    {
        sum += count;
        overallCount++;
        if (sum >= lengthToBeat)
            return overallCount;
    }
    
    return overallCount;
}