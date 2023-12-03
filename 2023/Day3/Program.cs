using AdventOfCodeUtil;

var filepath = "Input.txt";
var textReaderService = new TextFileReaderService();

var input = textReaderService.ReadTextFile(filepath);

// Assignment 1
const int INVALID = -1;
var p1 = 0;

var rows = input.Count;
var cols = input[0].Length;
var gears = new Dictionary<Symbol, List<int>>();

for (var row = 0; row < rows; row++)
{
    var r = input[row];
    var numStart = INVALID;
    for (var col = 0; col < cols; col++)
    {
        var c = r[col];
        if (char.IsDigit(c))
        {
            if (numStart == INVALID)
            {
                numStart = col;
            }
        }
        else
        {
            if (numStart != INVALID)
            {
                IsItValid(input, row, numStart, col - 1, r.Substring(numStart, col - numStart), gears);
            }
            numStart = INVALID;
        }
    }
    if (numStart != INVALID)
    {
        IsItValid(input, row, numStart, r.Length - 1, r.Substring(numStart), gears);
    }
}
Console.WriteLine("The sum in assignment 1 is: " + p1);

// Assignment 2
var p2 = 0;
foreach (var x in gears)
{
    if (x.Value.Count == 2)
    {
        p2 += x.Value[0] * x.Value[1];
    }
}
Console.WriteLine("The sum in assignment 2 is: " + p2);
            
void IsItValid(List<string> grid, int row, int start, int end, string r, Dictionary<Symbol, List<int>> gears)
{
    var adj = AdjacentSymbols(grid, row, start, end);
    if (adj.Any())
    {
        var cur = int.Parse(r);
        p1 += cur;
        foreach (var g in adj.Where(g => g.C == '*'))
        {
            gears[g] = gears.GetValueOrDefault(g, new List<int>()).Append(cur).ToList();
        }
    }
}

List<Symbol> AdjacentSymbols(List<string> grid, int row, int start, int end)
{
    var ret = new List<Symbol>();
    CheckForSymbol(grid, row, start - 1, ret);
    CheckForSymbol(grid, row, end + 1, ret);
    for (var col = start - 1; col <= end + 1; col++)
    {
        CheckForSymbol(grid, row - 1, col, ret);
        CheckForSymbol(grid, row + 1, col, ret);
    }
    return ret;
}

void CheckForSymbol(List<string> grid, int row, int col, List<Symbol> result)
{
    if (col >= 0 && col < grid[0].Length && row >= 0 && row < grid.Count)
    {
        var c = grid[row][col];
        if (!char.IsDigit(c) && c != '.')
        {
            result.Add(new Symbol(row, col, c));
        }
    }
}

public record Symbol(int Row, int Col, char C);