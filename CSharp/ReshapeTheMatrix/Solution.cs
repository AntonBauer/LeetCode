namespace ReshapeTheMatrix;

// 566. Reshape the Matrix
internal sealed class Solution
{
    public static int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        if (!IsValidReshape(mat, r, c))
            return mat;

        var reshaped = CreateReshaped(r, c);
        var origRows = mat.Length;
        var origCols = mat[0].Length;

        for (var i = 0; i < origRows; i++)
        {
            for (var j = 0; j < origCols; j++)
            {
                var flatIndex = ToFlat(i, j, origCols);
                var coord = ToMatrix(flatIndex, c);

                reshaped[coord.Row][coord.Col] = mat[i][j];
            }
        }

        return reshaped;
    }

    private static bool IsValidReshape(int[][] mat, int r, int c) => mat.Length * mat[0].Length == r * c;

    private static int[][] CreateReshaped(int rows, int columns)
    {
        var reshaped = new int[rows][];

        for (var i = 0; i < rows; i++)
            reshaped[i] = new int[columns];
        
        return reshaped;
    }

    private static int ToFlat(int i, int j, int columns) => i * columns + j;

    private static (int Row, int Col) ToMatrix(int flat, int columns) => (flat / columns, flat % columns);
}