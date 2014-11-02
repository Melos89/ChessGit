using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class PlayerAI
    {
        List<ChessPieces> Pieces; //Iniated a list to hold Chess pieces

        
        public PlayerAI(List<ChessPieces> pieces)//PlayerAI construct that takes in a list.
        {
           Pieces = pieces;
        }
        public List<ChessPieces> CanPiecesMove(List<ChessPieces> OwnList) /*Method that takes initial list, checks if a piece can move, 
           if the piece can move it gets placed in a new list that will be used to pick what piece to play.*/
        {
            List<ChessPieces> CanMoveList = new List<ChessPieces>(); 
            foreach (var piece in OwnList)
            {
                piece.CheckLocation(piece);
                if (piece.CanMove == true)
                {
                    CanMoveList.Add(piece);
                }
            }
            return CanMoveList;
        }
    }
}
