using System.Text;

const string alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

var solution1 = Day3.Resource.Input
    .TrimEnd()
    .Split("\r\n")
    .Select(x => new string[] { x.Substring(0, x.Length / 2), x.Substring(x.Length / 2) })
    .Select(x => x[0].Intersect(x[1]).First())
    .Select(x=> alpha.IndexOf(x)+1);

Console.WriteLine("Part1: " + solution1.Sum());

var solution2Start = Day3.Resource.Input
    .TrimEnd()
    .Split("\r\n");

var grouped = GetLines(solution2Start.ToArray());
var intersectAndScore = grouped
    .Select(x => x[0].Intersect(x[1]).Intersect(x[2]).First())
    .Select(x => alpha.IndexOf(x) + 1);

IEnumerable<string[]> GetLines(string[] inArray)
{
    for(int i = 0;i<inArray.Count();i=i+3)
    {
        yield return new string[] { inArray[i], inArray[i + 1], inArray[i + 2] };
    }
}

Console.WriteLine("Part2: " + intersectAndScore.Sum());