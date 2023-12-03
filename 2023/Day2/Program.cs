using AdventOfCodeUtil;

var filepath = "Input.txt";
var textReaderService = new TextFileReaderService();

var input = textReaderService.ReadTextFile(filepath);

// Assignment 1
var possibleGameIds = new List<int>();

foreach (var inputString in input)
{
    var line = inputString.Split(new[] { "Game " }, StringSplitOptions.RemoveEmptyEntries);

    // Configuration of cubes
    var redCubes = 12;
    var greenCubes = 13;
    var blueCubes = 14;

    // Parse game ID
    var game = line[0].Trim().Split(':');
    var gameId = int.Parse(game[0].Split(':')[0].Trim());

    foreach (var set in game.Skip(1))
    {
        var subsets = set.Trim().Split(';');
        var possibleSets = 0;

        foreach (var subset in subsets)
        {
            // Count cubes for each color in the game
            var cubeCounts = new Dictionary<string, int>
            {
                {"red", 0},
                {"green", 0},
                {"blue", 0}
            };

            var cubes = subset.Trim().Split(',');
            foreach (var cube in cubes)
            {
                var colourAndCubes = cube.Split(" ");
                colourAndCubes = colourAndCubes.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

                var color = colourAndCubes[1].ToLower();
                var count = int.Parse(colourAndCubes[0]);
                cubeCounts[color] += count;
            }

            if (cubeCounts["red"] <= redCubes && cubeCounts["green"] <= greenCubes && cubeCounts["blue"] <= blueCubes)
            {
                possibleSets++;
            }
        }

        if (possibleSets == subsets.Length)
        {
            possibleGameIds.Add(gameId);
        }
    }
}

Console.WriteLine("The sum in assignment 1 is: " + possibleGameIds.Sum());

// Assignment 2
var powerOfCubes = new List<int>();

foreach (var inputString in input)
{
    var line = inputString.Split(new[] { "Game " }, StringSplitOptions.RemoveEmptyEntries);

    // Parse game ID
    var game = line[0].Trim().Split(':');

    foreach (var set in game.Skip(1))
    {
        var subsets = set.Trim().Split(';');

        // Count cubes for each color in the game
        var cubeCounts = new Dictionary<string, int>
        {
            {"red", 0},
            {"green", 0},
            {"blue", 0}
        };

        foreach (var subset in subsets)
        {
            var cubes = subset.Trim().Split(',');
            foreach (var cube in cubes)
            {
                var colourAndCubes = cube.Split(" ");
                colourAndCubes = colourAndCubes.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

                var color = colourAndCubes[1].ToLower();
                var count = int.Parse(colourAndCubes[0]);
                
                if (cubeCounts[color] < count)
                {
                    cubeCounts[color] = count;
                }
            }
        }

        powerOfCubes.Add(cubeCounts["red"] * cubeCounts["green"] * cubeCounts["blue"]);
    }
}

Console.WriteLine("The sum of the power of the cubes for assignment 2 is: " + powerOfCubes.Sum());