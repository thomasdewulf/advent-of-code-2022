namespace Day2;

public class Round
{
    private int _initialScorePlayer1;
    private int _initialScorePlayer2;

    public Round(char player1Char, char player2Char)
    {
        _initialScorePlayer1 = GetInitialScorePlayer1(player1Char);
        _initialScorePlayer2 = GetInitialScorePlayer2(_initialScorePlayer1, player2Char);
    }

    public int GetScorePlayer2()
    {
        var score = _initialScorePlayer2;
        if (_initialScorePlayer1 == _initialScorePlayer2)
        {
            Console.WriteLine("TIE");
            score += 3;
            return score;
        }

        switch (_initialScorePlayer2)
        {
            case 1 when _initialScorePlayer1 == 3:
            case 2 when _initialScorePlayer1 == 1:
            case 3 when _initialScorePlayer1 == 2:
                Console.WriteLine("Player 2 wins");
                score += 6;
                break;
            default: Console.WriteLine("Player 1 wins");
                break;
        }


        return score;
    }

    private int GetInitialScorePlayer1(char character)
    {
        switch (character)
        {
            case 'A':
                return 1; //ROCK
            case 'B':
                return 2; //PAPER
            case 'C':
                return 3; // SCISSORS
            default: throw new ArgumentException("Case unsupported");
        }
    }
    
    private int GetInitialScorePlayer2(int initialScorePlayer1, char character)
    {
        switch (character)
        {
            case 'X': // LOSE
                return GetLosingMove(initialScorePlayer1);
            case 'Y': //DRAW
                return initialScorePlayer1;
            case 'Z':
                return GetWinningMove(initialScorePlayer1); // WIN
            default: throw new ArgumentException("Case unsupported");
        }
    }

    private int GetLosingMove(int move)
    {
        return move switch
        {
            1 => 3,
            2 => 1,
            3 => 2,
            _ => throw new IndexOutOfRangeException(nameof(move))
        };
    }

    private int GetWinningMove(int move)
    {
        return move switch
        {
            1 => 2,
            2 => 3,
            3 => 1,
            _ => throw new IndexOutOfRangeException(nameof(move))
        };
    }
}