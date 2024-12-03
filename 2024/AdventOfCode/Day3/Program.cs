using System.Text.RegularExpressions;
using AdventOfCodeUtil;

var input = TextFileReaderService.ReadTextFile("Input.txt").First();

// Assignment 1
var startTime = DateTime.UtcNow;

var pattern = @"mul\(\d+,\d+\)";
var matches = Regex.Matches(input, pattern);

var totalSum = matches
    .Sum(m => {
        var split = m.Value.Split(',', ')', '(');
        var num1 = int.Parse(split[1]);
        var num2 = int.Parse(split[2]);
        return num1 * num2;
    });

var endTime = DateTime.UtcNow;

Console.WriteLine($"Result: {totalSum}");
Console.WriteLine($"Total time: {endTime - startTime}");

// Assignment 2
startTime = DateTime.UtcNow;

pattern = @"\b(?:do|don['’]t)\(\)|mul\(\d+,\d+\)";
matches = Regex.Matches(input, pattern);

var enabled = true;

totalSum = matches
    .Sum(m => {
        if (m.Value == "do()")
        {
            enabled = true;
            return 0;
        }
        else if (m.Value == "don't()")
        {
            enabled = false;
            return 0;
        }

        if (enabled)
        {
            var split = m.Value.Split(',', ')', '(');
            var num1 = int.Parse(split[1]);
            var num2 = int.Parse(split[2]);
            return num1 * num2;   
        }
        return 0;
    });

endTime = DateTime.UtcNow;

Console.WriteLine($"Result: {totalSum}");
Console.WriteLine($"Total time: {endTime - startTime}");