using AdventOfCodeUtil;

var input = TextFileReaderService.ReadTextFile("Input.txt");

var reports = input.Select(report =>
        report.Split(' ')
        .Select(int.Parse)
        .ToList())
    .ToList();

// Assignment 1
var startTime = DateTime.UtcNow;

var safeReports = reports.Count(IsSafe);

var endTime = DateTime.UtcNow;

Console.WriteLine($"There are {safeReports} safe reports.");
Console.WriteLine($"Total time: {endTime - startTime}");

// Assignment 2
startTime = DateTime.UtcNow;

safeReports = reports
    .Select(BruteForce)
    .Count(variant => variant.Any(IsSafe));

endTime = DateTime.UtcNow;

Console.WriteLine($"There are {safeReports} safe reports with the Problem Dampener.");
Console.WriteLine($"Total time: {endTime - startTime}");

// Functions
static bool IsSafe(List<int> report)
{
    var levelDiffs = report.Zip(report.Skip(1), (a, b) => b - a).ToList();
    return levelDiffs.All(d => Math.Abs(d) >= 1 && Math.Abs(d) <= 3) &&
           (levelDiffs.All(d => d > 0) || levelDiffs.All(d => d < 0));
}

static IEnumerable<List<int>> BruteForce(List<int> report)
{
    for (var i = 0; i < report.Count; i++)
    {
        var variant = new List<int>(report);
        variant.RemoveAt(i);
        yield return variant;
    }
}