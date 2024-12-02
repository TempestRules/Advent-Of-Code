int[] raceTimes = { 47, 70, 75, 66 };
int[] recordDistances = { 282, 1079, 1147, 1062 };

long result = CalculateWaysToBeatRecord(raceTimes, recordDistances);

Console.WriteLine("Assignment 1 Result: " + result);

long[] raceTimes2 = { 47707566 };
long[] recordDistances2 = { 282107911471062 };

long result2 = CalculateWaysToBeatRecordLong(raceTimes2, recordDistances2);

Console.WriteLine("Assignment 2 Result: " + result2);

long CalculateWaysToBeatRecord(int[] raceTimes, int[] recordDistances)
{
    long totalWays = 1;

    for (int i = 0; i < raceTimes.Length; i++)
    {
        int maxHoldTime = raceTimes[i] - 1; // Maximum time to hold the button

        int recordDistance = recordDistances[i];
        long waysToBeatRecord = 0;

        for (int holdTime = 0; holdTime <= maxHoldTime; holdTime++)
        {
            int remainingTime = raceTimes[i] - holdTime - 1; // Remaining time after holding the button
            int totalDistance = (holdTime + 1) * remainingTime;

            if (totalDistance > recordDistance)
            {
                waysToBeatRecord++;
            }
        }

        totalWays *= waysToBeatRecord;
    }

    return totalWays;
}

long CalculateWaysToBeatRecordLong(long[] raceTimes, long[] recordDistances)
{
    long totalWays = 1;

    for (long i = 0; i < raceTimes.Length; i++)
    {
        long maxHoldTime = raceTimes[i] - 1; // Maximum time to hold the button

        long recordDistance = recordDistances[i];
        long waysToBeatRecord = 0;

        for (long holdTime = 0; holdTime <= maxHoldTime; holdTime++)
        {
            long remainingTime = raceTimes[i] - holdTime - 1; // Remaining time after holding the button
            long totalDistance = (holdTime + 1) * remainingTime;

            if (totalDistance > recordDistance)
            {
                waysToBeatRecord++;
            }
        }

        totalWays *= waysToBeatRecord;
    }

    return totalWays;
}