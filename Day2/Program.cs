

var solution1 = Day2.Resource.Input
    .TrimEnd()
    .Split("\r\n")
    .Select(x=>x.Split(' '))
    .Select(x=> ConvertHandsToMoves(x[0], x[1]))
    .Select(x=>ScoreHand(x));

Console.WriteLine("Part1: " + solution1.Sum());

var solution2 = Day2.Resource.Input
    .TrimEnd()
    .Split("\r\n")
    .Select(x => x.Split(' '))
    .Select(x => ConvertHandAndOutcomeToMoves(x[0], x[1]))
    .Select(x => ScoreHand(x));

Console.WriteLine("Part2: " + solution2.Sum());

int ScoreHand(game gameHand)
{
    int score = 0;
    //draw
    if (gameHand.firstMove == gameHand.secondMove)
        score += 3;
    //win
    if (gameHand.firstMove == move.Rock && gameHand.secondMove == move.Paper)
        score += 6;
    if (gameHand.firstMove == move.Scissors && gameHand.secondMove == move.Rock)
        score += 6;
    if (gameHand.firstMove == move.Paper && gameHand.secondMove == move.Scissors)
        score += 6;
    if (gameHand.secondMove == move.Rock)
        score += 1;
    if (gameHand.secondMove == move.Paper)
        score += 2;
    if (gameHand.secondMove == move.Scissors)
        score += 3;
    return score;
}

game ConvertHandsToMoves(string first, string second)
{
    move firstMove = move.Undefined, secondMove = move.Undefined;
    if (first == "A")
        firstMove = move.Rock;
    if (first == "B")
        firstMove = move.Paper;
    if (first == "C")
        firstMove = move.Scissors;
    if (second == "X")
        secondMove = move.Rock;
    if (second == "Y")
        secondMove = move.Paper;
    if(second == "Z")
        secondMove = move.Scissors;
    if (firstMove == move.Undefined || secondMove == move.Undefined)
        throw new Exception("Invalid move");
    return new game(firstMove, secondMove);
}

game ConvertHandAndOutcomeToMoves(string first, string second)
{
    move firstMove = move.Undefined, secondMove = move.Undefined;
    if (first == "A")
        firstMove = move.Rock;
    if (first == "B")
        firstMove = move.Paper;
    if (first == "C")
        firstMove = move.Scissors;
    //outcome
    if (second == "Y")
        secondMove = firstMove;
    if(second == "X")
    {
        if (firstMove == move.Rock)
            secondMove = move.Scissors;
        if (firstMove == move.Paper)
            secondMove = move.Rock;
        if (firstMove == move.Scissors)
            secondMove = move.Paper;
    }
    if(second == "Z")
    {
        if (firstMove == move.Rock)
            secondMove = move.Paper;
        if (firstMove == move.Paper)
            secondMove = move.Scissors;
        if (firstMove == move.Scissors)
            secondMove = move.Rock;
    }
    if (firstMove == move.Undefined || secondMove == move.Undefined)
        throw new Exception("Invalid move");
    return new game(firstMove, secondMove);
}

public enum move
{
    Undefined,
    Rock,
    Paper,
    Scissors
}
public record game(move firstMove,move secondMove);
