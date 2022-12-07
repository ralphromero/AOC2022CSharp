var input = Day6.Resource.Input;

int result1 = 0;
for(int i = 4;i < input.Length;i++)
{
    var startIndex = i - 4;
    var stuff = input[startIndex..i];
    if (stuff.Distinct().Count() == 4)
    {
        result1 = i;
        break;
    }
}

Console.WriteLine("Part1: " + result1);

int result2 = 0;
for (int i = 14; i < input.Length; i++)
{
    var startIndex = i - 14;
    var stuff = input[startIndex..i];
    if (stuff.Distinct().Count() == 14)
    {
        result2 = i;
        break;
    }
}

Console.WriteLine("Part2: " + result2);
