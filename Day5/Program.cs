using System.Text.RegularExpressions;

var input = Day5.Resource.Input
    .TrimEnd()
    .Split("\r\n");

var StackDesign = input
    .TakeWhile(x => x[1] != '1')
    .Select(x=>x.ToArray()).ToArray();


var TotalCount = StackDesign.First().Count();
var StackCount = TotalCount / 3;

//Init stack
Stack<char>[] stacks = new Stack<char>[StackCount];
for (int i = 0; i < StackCount; i++)
{
    stacks[i] = new Stack<char>();
}

//Populate stacks
foreach (var singleStack in StackDesign)
{
int count = 0;
    for (int i = 1; i < TotalCount; i = i + 4)
    {
        if (singleStack[i] != ' ')
            stacks[count].Push(singleStack[i]);
        count++;
    }
}

//Reverse all stacks because we loaded it in reverse
for(int i = 0; i < StackCount; i++)
{
    stacks[i] = new Stack<char>(stacks[i]);
}


var Movements = input
    .Where(x => x.StartsWith("move"))
    .Select(ParseDirections);

foreach (var movement in Movements)
{
    for(int i = 0; i < movement.amount; i++)
    {
        var hold = stacks[movement.fromStack-1].Pop();
        stacks[movement.toStack-1].Push(hold);
    }
}

var sol1 = new char[StackCount];
for(int i = 0; i < StackCount; i++)
{
    if (stacks[i].Count() > 0)
        sol1[i] = stacks[i].Pop();
}

Console.WriteLine("Part1: " + (new string(sol1)));

//Part2

//Init stack
Stack<char>[] stacks2 = new Stack<char>[StackCount];
for (int i = 0; i < StackCount; i++)
{
    stacks2[i] = new Stack<char>();
}

//Populate stacks
foreach (var singleStack in StackDesign)
{
    int count = 0;
    for (int i = 1; i < TotalCount; i = i + 4)
    {
        if (singleStack[i] != ' ')
            stacks2[count].Push(singleStack[i]);
        count++;
    }
}

//Reverse all stacks because we loaded it in reverse
for (int i = 0; i < StackCount; i++)
{
    stacks2[i] = new Stack<char>(stacks2[i]);
}

foreach (var movement in Movements)
{
    var tempStack = new Stack<char>();
    for (int i = 0; i < movement.amount; i++)
    {
        tempStack.Push(stacks2[movement.fromStack - 1].Pop());
    }

    for (int i = 0; i < movement.amount; i++)
    {
        stacks2[movement.toStack - 1].Push(tempStack.Pop());
    }
}

var sol2 = new char[StackCount];
for (int i = 0; i < StackCount; i++)
{
    if (stacks2[i].Count() > 0)
        sol2[i] = stacks2[i].Pop();
}

Console.WriteLine("Part2: " + (new string(sol2)));


Directions ParseDirections(string line)
{
    var amountMatch = Regex.Match(line, "(?<=move )\\d*");
    var fromMatch = Regex.Match(line, "(?<=from )\\d*");
    var toMatch = Regex.Match(line, "(?<=to )\\d*");
    return new Directions(Convert.ToInt32(amountMatch.Value), Convert.ToInt32(fromMatch.Value), Convert.ToInt32(toMatch.Value));
}
record Directions(int amount, int fromStack, int toStack);
