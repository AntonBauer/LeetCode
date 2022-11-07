namespace RotateImage;

// 48. Rotate Image
internal static class Solution
{
    public static void Rotate(int[][] matrix)
    {
        Transpose(matrix);
        ReverseRows(matrix);
    }

    private static void Transpose(int[][] matrix)
    {
        for (var i = 0; i < matrix.Length; i++)
        for (var j = i + 1; j < matrix[0].Length; j++)
            (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
    }

    private static void ReverseRows(int[][] matrix)
    {
        for (var i = 0; i < matrix.Length; i++)
        for (var j = 0; j < matrix.Length / 2; j++)
            (matrix[i][j], matrix[i][matrix.Length - 1 - j]) = (matrix[i][matrix.Length - 1 - j], matrix[i][j]);
    }
}