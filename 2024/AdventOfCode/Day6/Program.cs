using AdventOfCodeUtil;

var input = TextFileReaderService.ReadTextFile("Input.txt").ToArray();

// Assignment 1
var startTime = DateTime.UtcNow;

var simulator = new GuardSimulator(input);
var positions = simulator.SimulateGuardPath();

var endTime = DateTime.UtcNow;

Console.WriteLine($"The guard visits: {positions} distinct positions");
Console.WriteLine($"Total time: {endTime - startTime}");

// Assignment 2
startTime = DateTime.UtcNow;

simulator = new GuardSimulator(input);
var obstructionPositions = simulator.FindObstructionPositions();

endTime = DateTime.UtcNow;

Console.WriteLine($"There are {obstructionPositions} positions for obstructions");
Console.WriteLine($"Total time: {endTime - startTime}");

// Functions
public class GuardSimulator
{
    private HashSet<(int row, int col)> visited = new();
    private char[,] grid;
    private int currentRow;
    private int currentCol;
    private Direction currentDirection;

    private enum Direction
    {
        Up,
        Right,
        Down,
        Left
    }

    public GuardSimulator(string[] input)
    {
        grid = new char[input.Length, input[0].Length];

        // Parse input into grid and find starting position
        for (var row = 0; row < input.Length; row++)
        {
            for (var col = 0; col < input[row].Length; col++)
            {
                grid[row, col] = input[row][col];
                if (input[row][col] == '^')
                {
                    currentRow = row;
                    currentCol = col;
                    currentDirection = Direction.Up;
                    grid[row, col] = 'X'; // Replace start position with empty space
                }
            }
        }
    }

    public int SimulateGuardPath()
    {
        visited.Add((currentRow, currentCol));

        while (IsInBounds(currentRow, currentCol))
        {
            if (IsBlocked(currentRow, currentCol, currentDirection))
            {
                TurnRight();
            }
            else
            {
                MoveForward();

                if (IsInBounds(currentRow, currentCol))
                {
                    visited.Add((currentRow, currentCol));
                }
            }
        }

        return visited.Count;
    }

    public int FindObstructionPositions()
    {
        HashSet<(int row, int col)> validObstructions = new();

        for (var row = 0; row < grid.GetLength(0); row++)
        {
            for (var col = 0; col < grid.GetLength(1); col++)
            {
                // Skip blocked positions and the starting position
                if (grid[row, col] == '#' || (row == currentRow && col == currentCol))
                {
                    continue;
                }

                // Temporarily place an obstruction
                var original = grid[row, col];
                grid[row, col] = '#';

                if (CausesLoop())
                {
                    validObstructions.Add((row, col));
                }

                // Remove the obstruction
                grid[row, col] = original;
            }
        }

        return validObstructions.Count;
    }

    private bool CausesLoop()
    {
        HashSet<(int row, int col, Direction)> visitedStates = new();
        var tempRow = currentRow;
        var tempCol = currentCol;
        Direction tempDirection = currentDirection;

        while (IsInBounds(tempRow, tempCol))
        {
            if (IsBlocked(tempRow, tempCol, tempDirection))
            {
                tempDirection = TurnRight(tempDirection);
            }
            else
            {
                (tempRow, tempCol) = MoveForward(tempRow, tempCol, tempDirection);
            }

            if (!visitedStates.Add((tempRow, tempCol, tempDirection)))
            {
                return true;
            }
        }

        return false;
    }

    private bool IsBlocked(int row, int col, Direction direction)
    {
        var (nextRow, nextCol) = GetNextPosition(row, col, direction);

        if (!IsInBounds(nextRow, nextCol))
        {
            return false;
        }

        return grid[nextRow, nextCol] == '#';
    }

    private (int row, int col) GetNextPosition(int row, int col, Direction direction)
    {
        return direction switch
        {
            Direction.Up => (row - 1, col),
            Direction.Right => (row, col + 1),
            Direction.Down => (row + 1, col),
            Direction.Left => (row, col - 1),
            _ => throw new ArgumentException("Invalid direction")
        };
    }

    private bool IsInBounds(int row, int col)
    {
        return row >= 0 && row < grid.GetLength(0) &&
               col >= 0 && col < grid.GetLength(1);
    }

    private void TurnRight()
    {
        currentDirection = currentDirection switch
        {
            Direction.Up => Direction.Right,
            Direction.Right => Direction.Down,
            Direction.Down => Direction.Left,
            Direction.Left => Direction.Up,
            _ => throw new ArgumentException("Invalid direction")
        };
    }

    private Direction TurnRight(Direction direction)
    {
        return direction switch
        {
            Direction.Up => Direction.Right,
            Direction.Right => Direction.Down,
            Direction.Down => Direction.Left,
            Direction.Left => Direction.Up,
            _ => throw new ArgumentException("Invalid direction")
        };
    }

    private void MoveForward()
    {
        var (nextRow, nextCol) = GetNextPosition(currentRow, currentCol, currentDirection);
        currentRow = nextRow;
        currentCol = nextCol;
    }

    private (int row, int col) MoveForward(int row, int col, Direction direction)
    {
        var (nextRow, nextCol) = GetNextPosition(row, col, direction);
        return (nextRow, nextCol);
    }
}