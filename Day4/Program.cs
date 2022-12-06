var solution1 = Day4.Resource.Input
    .TrimEnd()
    .Split("\r\n")
    .Select(x => x.Split(','))
    .Select(x => ContainsAll(ConvertArrayToTuple(ConvertRangeToArray(x[0])), ConvertArrayToTuple(ConvertRangeToArray(x[1]))));

int[] ConvertRangeToArray(string range) => range.Split('-').Select(z => Convert.ToInt32(z)).ToArray();

(int,int) ConvertArrayToTuple(int[] range) => (range[0], range[1]);

bool ContainsAll((int start,int end) firstElf, (int start,int end) secondElf)
{
    if(firstElf.start <= secondElf.start && firstElf.end >= secondElf.end)
        return true;
    if (secondElf.start <= firstElf.start && secondElf.end >= firstElf.end)
        return true;
    return false;
}

bool ContainsAny((int start, int end) firstElf, (int start, int end) secondElf)
{
    var firstElfRange = Enumerable.Range(firstElf.start, firstElf.end - firstElf.start + 1);
    var secondElfRange = Enumerable.Range(secondElf.start, secondElf.end - secondElf.start + 1);
    var common = firstElfRange.Intersect(secondElfRange);
    if (common.Count() > 0)
        return true;
    return false;
}

Console.WriteLine("Part1: " + solution1.Where(x=>x == true).Count());

var solution2 = Day4.Resource.Input
    .TrimEnd()
    .Split("\r\n")
    .Select(x => x.Split(','))
    .Select(x => ContainsAny(ConvertArrayToTuple(ConvertRangeToArray(x[0])), ConvertArrayToTuple(ConvertRangeToArray(x[1]))));

Console.WriteLine("Part2: " + solution2.Where(x => x == true).Count());