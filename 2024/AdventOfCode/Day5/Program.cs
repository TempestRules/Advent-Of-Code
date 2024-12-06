using AdventOfCodeUtil;
using System.Text.RegularExpressions;

var input = TextFileReaderService.ReadTextFile("Input.txt");

var fullInput = string.Join("\n", input);
var orderingRules = Regex.Matches(fullInput, @"\d+\|\d+")
                         .Select(m =>
                         {
                             var split = m.Value.Split("|");
                             return (int.Parse(split[0]), int.Parse(split[1]));
                         })
                         .ToList();

var updates = input.GetRange(orderingRules.Count + 1, input.Count - orderingRules.Count - 1)
    .Select(line =>
    {
        var split = line.Split(",");
        var list = split.Select(int.Parse).ToList();
        return list;
    })
    .ToList();

// Assignment 1
var startTime = DateTime.UtcNow;

var printOrder = new List<List<int>>(updates.Count);

var unchangedIndexes = new List<int>();
var shiftedIndexes = new List<int>();

for (var i = 0; i < updates.Count; i++)
{
    var current = new List<int>(updates[i]);
    var allowLoop = true;
    var firstSuccess = false;
    var attemptCounter = 0;
    while (allowLoop)
    {
        allowLoop = CheckPrintOrder(current, orderingRules, out var failedAt) == false;
        if (attemptCounter == 0 && allowLoop == false)
        {
            firstSuccess = true;
        }

        if (failedAt != null)
        {
            var fai = (int)failedAt;
            var c = current[fai];
            var cc = current[fai - 1];
            current[fai] = cc;
            current[fai - 1] = c;
        }

        attemptCounter++;
    }

    if (firstSuccess)
    {
        unchangedIndexes.Add(i);
    }
    else
    {
        shiftedIndexes.Add(i);
    }

    printOrder.Add(current);
}

var partOne = FindMiddleSum(unchangedIndexes, printOrder);

var endTime = DateTime.UtcNow;

Console.WriteLine($"Part 1: {partOne}");
Console.WriteLine($"Total time: {endTime - startTime}");

// Assignment 2
startTime = DateTime.UtcNow;

var partTwo = FindMiddleSum(shiftedIndexes, printOrder);

endTime = DateTime.UtcNow;

Console.WriteLine($"Part 2: {partTwo}");
Console.WriteLine($"Total time: {endTime - startTime}");

// Functions
bool CheckPrintOrder(List<int> printOrder, List<(int, int)> orderingRules, out int? failedAt)
{
    failedAt = null;
    for (var i = 0; i < printOrder.Count; i++)
    {
        foreach (var (x, y) in orderingRules)
        {
            if (printOrder[i] == x)
            {
                var yi = printOrder.IndexOf(y);
                if (yi > -1 && yi < i)
                {
                    failedAt = i;
                    return false;
                }
            }
        }
    }

    return true;
}

int FindMiddleSum(List<int> correctPrintOrderIndexes, List<List<int>> existingPageNumbers)
{
    var sum = 0;
    for (var i = 0; i < correctPrintOrderIndexes.Count; i++)
    {
        var c = correctPrintOrderIndexes[i];
        var val = existingPageNumbers[c];
        var midIndex = Convert.ToInt32(Math.Max(Math.Floor(val.Count / 2f), 0));
        var midVal = val[midIndex];
        sum += midVal;
    }

    return sum;
}
