using AdventOfCodeUtil;

var input = TextFileReaderService.ReadTextFile("Input.txt");

// Assignment 1
var startTime = DateTime.UtcNow;

var leftList = new List<int>();
var rightList = new List<int>();

foreach (var line in input)
{
    var lists = line.Split("   ");

    leftList.Add(int.Parse(lists[0]));
    rightList.Add(int.Parse(lists[1]));
}

leftList.Sort();
rightList.Sort();

var totalDistance = leftList
    .Zip(rightList, (left, right) => Math.Abs(right - left))
    .Sum();

var endTime = DateTime.UtcNow;

Console.WriteLine($"The total distance is: {totalDistance}");
Console.WriteLine($"Total time: {endTime - startTime}");

// Assignment 2
startTime = DateTime.UtcNow;

var similarityScore = 0;
foreach (var locationId in leftList)
{
    var count = rightList.Count(x => x == locationId);

    similarityScore += locationId * count;
}

endTime = DateTime.UtcNow;

Console.WriteLine($"The similarity score is: {similarityScore}");
Console.WriteLine($"Total time: {endTime - startTime}");