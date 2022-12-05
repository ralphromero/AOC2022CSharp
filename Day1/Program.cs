var input = Day1.Resource.Input1
    .TrimEnd()
    .Split("\r\n\r\n")
    .Select(x => x.Split("\r\n").Select(x => Convert.ToInt32(x)))
    .Select(sample1 => sample1.Sum())
    .OrderByDescending(x => x);

Console.WriteLine("Part1: " + input.Max());

Console.WriteLine("Part2: " + input.Take(3).Sum());