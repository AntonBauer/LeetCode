namespace MinNumberRefuelingStops;

internal static class Solution
{
    public static int MinRefuelStops(int target, int startFuel, int[][] stations) =>
        CalculateMinRefuelStops(0, startFuel, AddTargetAsEmptyStation(target, stations), 0);

    private static int CalculateMinRefuelStops(int currentPosition, int currentFuel, int[][] stations, int currentStops)
    {
        var furthestReachableIndex = FurthestReachableIndex(stations, currentPosition, currentFuel);
        var reachableStations =
            furthestReachableIndex < 0 ? Array.Empty<int[]>() : stations[..(furthestReachableIndex + 1)];

        if (!reachableStations.Any())
            return -1;
        if (reachableStations.Length == stations.Length)
            return currentStops;

        for (var i = reachableStations.Length - 1; i >= 0; i--)
        {
            var currentStation = reachableStations[i];
            var newPosition = currentStation[0];
            var newFuel = currentFuel - (currentStation[0] - currentPosition) + currentStation[1];
            var newStations = stations[(furthestReachableIndex + 1)..];

            var stops = CalculateMinRefuelStops(newPosition, newFuel, newStations, currentStops + 1);
            if (stops >= 0)
                return stops;
        }

        return -1;
    }

    private static int[][] AddTargetAsEmptyStation(int target, int[][] stations)
    {
        var includeEnd = new int[stations.Length + 1][];
        stations.CopyTo(includeEnd, 0);
        includeEnd[^1] = new[] { target, 0 };

        return includeEnd;
    }

    private static int FurthestReachableIndex(int[][] stations, int currentPosition, int currentFuel)
    {
        for (var i = stations.Length - 1; i >= 0; i--)
        {
            if (!IsReachable(stations[i], currentPosition, currentFuel))
                continue;

            return i;
        }

        return -1;
    }

    private static bool IsReachable(int[] station, int currentPosition, int currentFuel) =>
        station[0] - currentPosition <= currentFuel;
}