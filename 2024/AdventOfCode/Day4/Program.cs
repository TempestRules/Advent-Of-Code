using AdventOfCodeUtil;
using System.Text.RegularExpressions;

var input = TextFileReaderService.ReadTextFile("Input.txt");

// Assignment 1
var startTime = DateTime.UtcNow;

var xmasCounter = 0;

// Horizontal
var fullInput = string.Join("\n", input);
xmasCounter += Regex.Matches(fullInput, "(XMAS)", RegexOptions.None).Count;
xmasCounter += Regex.Matches(fullInput, "(SAMX)", RegexOptions.None).Count;

var X = 'X';
var M = 'M';
var A = 'A';
var S = 'S';

var diagonalEdgeLimit = input[0].Length - 3;

for (var row = 0; row < input.Count - 3; row++)
{
    for (var column = 0; column < input[0].Length; column++)
    {
        // Vertical
        if (input[row][column] == X
            && input[row + 1][column] == M
            && input[row + 2][column] == A
            && input[row + 3][column] == S)
        {
            xmasCounter++;
        }

        if (input[row][column] == S
            && input[row + 1][column] == A
            && input[row + 2][column] == M
            && input[row + 3][column] == X)
        {
            xmasCounter++;
        }

        // Diagonal right
        if (column < diagonalEdgeLimit)
        {
            if (input[row][column] == X
                && input[row + 1][column + 1] == M
                && input[row + 2][column + 2] == A
                && input[row + 3][column + 3] == S)
            {
                xmasCounter++;
            }
            if (input[row][column] == S
                && input[row + 1][column + 1] == A
                && input[row + 2][column + 2] == M
                && input[row + 3][column + 3] == X)
            {
                xmasCounter++;
            }
        }

        // Diagonal left
        if (column >= 3)
        {
            if (input[row][column] == X
                && input[row + 1][column - 1] == M
                && input[row + 2][column - 2] == A
                && input[row + 3][column - 3] == S)
            {
                xmasCounter++;
            }

            if (input[row][column] == S
                && input[row + 1][column - 1] == A
                && input[row + 2][column - 2] == M
                && input[row + 3][column - 3] == X)
            {
                xmasCounter++;
            }
        }
    }
}

var endTime = DateTime.UtcNow;

Console.WriteLine($"XMAS appears: {xmasCounter} times");
Console.WriteLine($"Total time: {endTime - startTime}");

// Assignment 2
startTime = DateTime.UtcNow;

xmasCounter = 0;
var masCounter = 0;

for (var row = 0; row < input.Count - 2; row++)
{
    for (var column = 0; column < input[0].Length - 2; column++)
    {
        masCounter = 0;

        // Top left to bottom right
        if (input[row][column] == M 
            && input[row + 1][column + 1] == A
            && input[row + 2][column + 2] == S)
        {
            masCounter++;
        }

        // Top right to bottom left
        if (input[row][column + 2] == M
            && input[row + 1][column + 1] == A
            && input[row + 2][column] == S)
        {
            masCounter++;
        }

        // Bottom left to top right
        if (input[row][column] == S
            && input[row + 1][column + 1] == A
            && input[row + 2][column + 2] == M)
        {
            masCounter++;
        }

        // Bottom right to top left
        if (input[row][column + 2] == S
            && input[row + 1][column + 1] == A
            && input[row + 2][column] == M)
        {
            masCounter++;
        }

        if (masCounter == 2)
        {
            xmasCounter++;
        }
    }
}

endTime = DateTime.UtcNow;

Console.WriteLine($"X-MAS appears: {xmasCounter} times");
Console.WriteLine($"Total time: {endTime - startTime}");