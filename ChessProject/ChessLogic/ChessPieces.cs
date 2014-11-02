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
        public int PreviousX { get; set; }//To get the old value
        public int PreviousY { get; set; }//To get the old value
        public bool CanMove { get; set; }//set to true if its possible to move
        public virtual void TellPosition() //start position Method that will be overridden by any piece containing an override method to be relevant for each seperate piece
        {
        }
        public virtual void TellNewPosition(ChessPieces piece)//next position method that will be overriden by any piece containing an override method
        {
        }
        public void TellUs(ChessPieces piece) //Calls a method that will print out a piece name and start location
        {
                piece.TellPosition(); 
        }
        public void TellNewShitYo(ChessPieces piece)//calls another method that prints a piece new location
        {
                piece.TellNewPosition(piece);
        }
        public ChessPieces CheckLocation(ChessPieces piece) //Move rules for all pieces, 
        {
            if (piece.colour == "W" && piece.type == "Pawn")
            {
                if (PositionY++ == null)
                {
                    CanMove = true;
                }
                else
                {
                    CanMove = false;
                }
            }
            if (piece.colour == "B" && piece.type == "Pawn")
            {
                if (PositionY-- == null)
                {
                    CanMove = true;
                }
                else
                {
                    CanMove = false;
                }
            }
            return piece;
        }
    }
}
