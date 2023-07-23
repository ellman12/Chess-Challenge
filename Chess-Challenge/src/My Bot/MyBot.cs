using System;
using System.Linq;
using ChessChallenge.API;

namespace Chess_Challenge.My_Bot;

public class MyBot : IChessBot
{
	private static readonly Random random = new();
	
    public Move Think(Board board, Timer timer)
    {
	    Move[] moves = board.GetLegalMoves();
	    Move move = moves.FirstOrDefault(m => m.MovePieceType == PieceType.King);

	    if (move == default)
	    {
		    int index = random.Next(0, moves.Length);
		    move = moves[index];
	    }
	    
	    return move;
    }
}