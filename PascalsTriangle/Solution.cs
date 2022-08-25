namespace PascalsTriangle;

// 118. Pascal's Triangle
internal static class Solution
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var triangle = new IList<int>[numRows];
        var currentRow = Array.Empty<int>();

        for (var i = 0; i < numRows; i++)
        {
            var row = CreateRow(i, currentRow);
            triangle[i] = row;
            currentRow = row;
        }
        
        return triangle;
    }

    private static int[] CreateRow(int rowNumber, int[] prevRow)
    {
        switch (rowNumber)
        {
            case 0:
                return new[] { 1 };
            case 1:
                return new[] { 1, 1 };
            default:
                var row = new int[rowNumber + 1];
                row[0] = 1;
                row[^1] = 1;

                for (var i = 1; i < row.Length - 1; i++)
                    row[i] = prevRow[i - 1] + prevRow[i];
                
                return row;
        }
    }
}