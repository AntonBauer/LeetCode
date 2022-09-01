namespace Search2dMatrix;

// 74. Search a 2D Matrix
internal static class Solution
{
    public static bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix[0][0] > target)
            return false;
        if (matrix[^1][^1] < target)
            return false;
        
        for (var i = 0; i < matrix.Length; i++)
        {
            var row = matrix[i];
            if (row[0] <= target && row[^1] >= target)
                return row.Contains(target);
        }
        
        return false;
    }
}