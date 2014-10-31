using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public abstract class ChessPieces : MovePieces//Our base class for pieces, ((Possible inheritance for getset new positions? or waste of space.))
    {
        public int strength { get; set; }//Their value
        public string colour { get; set; }
        internal string type;//Their type (e.g Pawn)
        public PairPos XYPos; //Created an instance of the co-ordinates class to save away the pieces location
        public int PositionX { get; set; }//Property to get and set the X position on the board,
        public int PositionY { get; set; }//Property to get and set the Y position on the board,
        public int PreviousX { get; set; }
        public int PreviousY { get; set; }
        public virtual void TellPosition() //Method that will be overridden by a piece with a different reaction from each type of piece
        {
        }
        public virtual void TellNewPosition(ChessPieces piece)
        {
        }
        public void TellUs(ChessPieces piece) //Calls a method in pawn that will print out its name and location
        {
                piece.TellPosition(); 
        }
        public void TellNewShitYo(ChessPieces piece)
        {
                piece.TellNewPosition(piece);
        }
    }
}
