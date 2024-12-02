﻿using AdventOfCodeUtil;
using System.Diagnostics;

var filepath = "Input.txt";
var textReaderService = new TextFileReaderService();

var Input = textReaderService.ReadTextFile(filepath);

// Data Preparation
var watch = Stopwatch.StartNew();

var seeds = Input[0].Split(' ').Skip(1).Select(x => long.Parse(x)).ToList();
var maps = new List<List<(long from, long to, long adjustment)>>();
List<(long from, long to, long adjustment)>? currmap = null;

foreach (var line in Input.Skip(2))
{
    if (line.EndsWith(':'))
    {
        currmap = new List<(long from, long to, long adjustment)>();
        continue;
    }
    else if (line.Length == 0 && currmap != null)
    {
        maps.Add(currmap!);
        currmap = null;
        continue;
    }

    var nums = line.Split(' ').Select(x => long.Parse(x)).ToArray();
    currmap!.Add((nums[1], nums[1] + nums[2] - 1, nums[0] - nums[1]));
}
if (currmap != null)
    maps.Add(currmap);

// Assignment 1
var result1 = long.MaxValue;

foreach (var seed in seeds)
{
    var value = seed;
    foreach (var map in maps)
    {
        foreach (var item in map)
        {
            if (value >= item.from && value <= item.to)
            {
                value += item.adjustment;
                break;
            }
        }
    }
    result1 = Math.Min(result1, value);
}

// Assignment 2
var ranges = new List<(long from, long to)>();
for (int i = 0; i < seeds.Count; i += 2)
    ranges.Add((from: seeds[i], to: seeds[i] + seeds[i + 1] - 1));

foreach (var map in maps)
{
    var orderedmap = map.OrderBy(x => x.from).ToList();

    var newranges = new List<(long from, long to)>();
    foreach (var r in ranges)
    {
        var range = r;
        foreach (var mapping in orderedmap)
        {
            if (range.from < mapping.from)
            {
                newranges.Add((range.from, Math.Min(range.to, mapping.from - 1)));
                range.from = mapping.from;
                if (range.from > range.to)
                    break;
            }

            if (range.from <= mapping.to)
            {
                newranges.Add((range.from + mapping.adjustment, Math.Min(range.to, mapping.to) + mapping.adjustment));
                range.from = mapping.to + 1;
                if (range.from > range.to)
                    break;
            }
        }
        if (range.from <= range.to)
            newranges.Add(range);
    }
    ranges = newranges;
}
var result2 = ranges.Min(r => r.from);

watch.Stop();

Console.WriteLine($"Result1 = {result1}");
Console.WriteLine($"Result2 = {result2}");
Console.WriteLine($"Took = {watch.ElapsedMilliseconds}ms");