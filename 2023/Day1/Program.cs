using AdventOfCodeUtil;
using System.Text.RegularExpressions;

var filepath = "Input.txt";
var textReaderService = new TextFileReaderService();

var input = textReaderService.ReadTextFile(filepath);

// Assignment 1
var pattern = "\\d";

var sum = 0;
foreach (var line in input)
{
    var matches = Regex.Matches(line, pattern);
    var firstDigit = matches[0];
    var lastDigit = matches[matches.Count() - 1];

    sum += int.Parse(firstDigit.ToString() + lastDigit.ToString());
}

Console.WriteLine("The value of the first assignment is: " + sum);

// Assignment 2
pattern = $"(?:zero|one|two|three|four|five|six|seven|eight|nine|\\d)";
sum = 0;

foreach (var line in input)
{
    var matches = Regex.Matches(line, pattern);
    var firstDigit = ConvertToInt(matches[0].ToString());

    matches = Regex.Matches(line, pattern, RegexOptions.RightToLeft);
    var lastDigit = ConvertToInt(matches[0].ToString());

    sum += int.Parse(firstDigit.ToString() + lastDigit.ToString());
}

Console.WriteLine("The value of the second assignment is: " + sum);

string ConvertToInt(string numberString)
{
    var spelledOutNumbers = new Dictionary<string, string>
    {
        {"one", "1"},
        {"two", "2"},
        {"three", "3"},
        {"four", "4"},
        {"five", "5"},
        {"six", "6"},
        {"seven", "7"},
        {"eight", "8"},
        {"nine", "9"}
    };

    var number = string.Empty;

    var charNumber = numberString.ToCharArray();

    if (char.IsNumber(charNumber[0]))
    {
        number = numberString;
    }
    else
    {
        number = spelledOutNumbers[numberString];
    }

    return number;
}