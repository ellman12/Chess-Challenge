using System;
using System.Linq;
using ChessChallenge.API;

namespace Chess_Challenge.My_Bot;

public class MyBot : IChessBot
{
	private static readonly Random random = new();

    public Move Think(Board board, Timer timer)
    {
	    Move[] legalMoves = board.GetLegalMoves();

	    Move[] possibleMoves = legalMoves.Where(m => m is {MovePieceType: PieceType.King, IsCapture: true}).ToArray();
	    if (possibleMoves.Length > 0) return possibleMoves[random.Next(0, possibleMoves.Length)];

	    possibleMoves = legalMoves.Where(m => m.MovePieceType == PieceType.King).ToArray();
	    if (possibleMoves.Length > 0) return possibleMoves[random.Next(0, possibleMoves.Length)];
	    
	    return legalMoves[random.Next(0, legalMoves.Length)];
    }
}