using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Pawn : ChessPieces
    {
        public Pawn(PairPos stuff, int Colour, string thing)
        {/*Constructor that takes a class, then saves the X/Y values 
          * and a string with the colour of the piece.*/
            XYPos = stuff;
            colour = Colour;
            type = thing;
        }
        public override void TellPosition()// Sets the cursor position at the supplied X/Y co-ordinates and prints out The piece at its location
        {
            PositionX = XYPos.X;
            PositionY = XYPos.Y;
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(colour + "P");
            
        }
        public override void TellNewPosition(ChessPieces piece)
        {
            PreviousX = PositionX;
            PreviousY = PositionY;
            PositionX = piece.PositionX;
            PositionY = piece.PositionY;
            Console.SetCursorPosition(PreviousX, PreviousY);
            Console.Write("  ");
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(colour + "P");

        }
        public void DoImportantStuff()//Useless
        {
            Console.WriteLine("Farming yo");
        }
        
    }
}
