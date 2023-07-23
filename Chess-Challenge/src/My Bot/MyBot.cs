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
	    Move move;
	    int index;
	    
	    Move[] kingMoves = moves.Where(m => m.MovePieceType == PieceType.King).ToArray();
	    if (kingMoves.Length > 0)
	    {
		    index = random.Next(0, kingMoves.Length);
		    move = kingMoves[index];
	    }
	    else
	    {
		    index = random.Next(0, moves.Length);
		    move = moves[index];
	    }
	    
	    return move;
    }
}