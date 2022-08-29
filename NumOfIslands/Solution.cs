namespace NumOfIslands;

// 200. Number of Islands
internal static class Solution
{
    private record Position(int Row, int Column);

    private static int _rows;
    private static int _columns;
    
    private static void Init(char[][] grid)
    {
        _rows = grid.Length;
        _columns = grid[0].Length;
    }

    public static int NumOfIslands(char[][] grid)
    {
        Init(grid);
        
        var flatMap = new int[_rows * _columns];

        var lastIslandNum = 0;
        Position islandPosition;

        do
        {
            islandPosition = FindNextIsland(flatMap, grid);
            if (islandPosition.Row == _rows && islandPosition.Column == _columns)
                return lastIslandNum;

            ++lastIslandNum;
            ExploreIsland(islandPosition, grid, lastIslandNum, flatMap);
        } while (islandPosition.Row < _rows && islandPosition.Column < _columns);

        return lastIslandNum;
    }
    
    private static Position FindNextIsland(int[] flatMap, char[][] map)
    {
        for(var i = 0; i < _rows; i++)
        for (var j = 0; j < _columns; j++)
        {
            var pos = new Position(i, j);
            if (map[i][j] == '1' && flatMap[ToFlat(pos)] == 0)
                return pos;
        }
        
        return new Position(_rows, _columns);
    }

    private static void ExploreIsland(Position start, char[][] map, int islandNum, int[] flatMap)
    {
        if (start.Row >= _rows && start.Column >= _columns)
            return;
        
        if(map[start.Row][start.Column] == '0')
            return;

        var flatPosition = ToFlat(start);
        if(flatMap[flatPosition] != 0)
            return;
        
        flatMap[flatPosition] = islandNum;

        // Explore right
        if (start.Column < _columns)
            ExploreIsland(start with { Column = start.Column + 1 }, map, islandNum, flatMap);
        
        // Explore down
        if(start.Row < _rows)
            ExploreIsland(start with {Row = start.Row + 1}, map, islandNum, flatMap);
    }

    private static int ToFlat(Position position) => position.Row * _columns + position.Column;
}