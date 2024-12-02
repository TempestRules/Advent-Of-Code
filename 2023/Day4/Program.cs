using AdventOfCodeUtil;

var filepath = "Input.txt";
var textReaderService = new TextFileReaderService();

var Input = textReaderService.ReadTextFile(filepath);

// Assignment 1
var numberOfWins = Input.Select(s => s[s.IndexOf(':')..s.IndexOf('|')].Split(' ', StringSplitOptions.RemoveEmptyEntries)
.Intersect(s[(s.IndexOf('|') + 1)..].Split(' ', StringSplitOptions.RemoveEmptyEntries)).Count()).ToList();

int part1Answer = numberOfWins.Where(w => w != 0).Sum(s => (int)Math.Pow(2, s - 1));

Console.WriteLine($"Assignment 1: The scratchcards are worth {part1Answer} in total");

// Assignment 2
var numberOfTickets = Enumerable.Repeat(1, numberOfWins.Count).ToList();

for (int i = 0; i < numberOfWins.Count; i++)
{
    for (int j = 1; j <= numberOfWins[i]; j++)
    {
        numberOfTickets[i + j] += numberOfTickets[i];
    }
}

int part2Answer = numberOfTickets.Sum();

Console.WriteLine($"Assignment 2: You end up with {part2Answer} scratchcards.");