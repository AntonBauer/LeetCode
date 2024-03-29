﻿namespace PacificAtlanticWaterFlow;

// 417. Pacific Atlantic Water Flow
internal record Position(int Row, int Col);

internal static class Solution
{
    private enum ExitTo
    {
        Pacific,
        Atlantic
    }

    public static int[][] PacificAtlantic(int[][] heights)
    {
        var exits = new Dictionary<Position, HashSet<ExitTo>>();
        var rows = heights.Length;
        var cols = heights[0].Length;

        for (var i = 0; i < heights.Length; i++)
        for (var j = 0; j < heights[0].Length; j++)
            FindExits(new Position(i, j), heights, exits, rows, cols);

        return exits.Where(e => e.Value.Count == 2).Select(e => new[] { e.Key.Row, e.Key.Col }).ToArray(); 
    }

    private static void FindExits(Position position, int[][] island, Dictionary<Position, HashSet<ExitTo>> exits, int rows, int cols)
    {
        if (exits.ContainsKey(position)) return;

        exits.Add(position, new HashSet<ExitTo>());
        
        if (position.IsDirectPacific())
            exits[position].Add(ExitTo.Pacific);

        if (position.IsDirectAtlantic(rows, cols))
            exits[position].Add(ExitTo.Atlantic);

        foreach (var neighbour in position.Neighbours(rows, cols).Where(n => island.HeightIn(n) <= island.HeightIn(position)))
        {
            if (!exits.ContainsKey(neighbour))
                FindExits(neighbour, island, exits, rows, cols);

            exits[position].UnionWith(exits[neighbour]);
        }
    }
}

internal static class Extensions
{
    public static bool IsDirectPacific(this Position pos) => pos.Row == 0 || pos.Col == 0;

    public static bool IsDirectAtlantic(this Position pos, int rows, int cols) =>
        pos.Row == rows - 1 || pos.Col == cols - 1;

    public static IEnumerable<Position> Neighbours(this Position currentPosition, int rows, int columns)
    {
        // Top
        if (currentPosition.Row > 0)
            yield return currentPosition with { Row = currentPosition.Row - 1 };

        // Right
        if (currentPosition.Col < columns - 1)
            yield return currentPosition with { Col = currentPosition.Col + 1 };

        // Down
        if (currentPosition.Row < rows - 1)
            yield return currentPosition with { Row = currentPosition.Row + 1 };

        // Left
        if (currentPosition.Col > 0)
            yield return currentPosition with { Col = currentPosition.Col - 1 };
    }

    public static int HeightIn(this int[][] map, Position pos) => map[pos.Row][pos.Col];
}