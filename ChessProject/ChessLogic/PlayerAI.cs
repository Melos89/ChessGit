using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class PlayerAI
    {
        List<ChessPieces> Pieces;
        Random randomizer = new Random();
        public PlayerAI(List<ChessPieces> pieces)//PlayerAI construct that takes in a list.
        {
           Pieces = pieces;
        }
        public int RandomChesspiece(List<ChessPieces> pieces)
        {
           int svar = randomizer.Next(pieces.Count);
            return svar;
        }
        public static void moveShapes(List<ChessPieces> pieces)
        {
            foreach (var item in pieces)
            {
                PairPos P = item.GetLocation();
                item.SetLocation(P);
            }
        }
    }
}
