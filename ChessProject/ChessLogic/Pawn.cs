using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Pawn : ChessPieces
    {

        public Pawn(PairPos stuff)
        {
            XYPos = stuff;
        }
        public override void TellPosition()
        {
            PositionX = XYPos.X;
            PositionY = XYPos.Y;
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write("Pawn");
            
        }
        public void DoImportantStuff()
        {
            Console.WriteLine("Farming yo");
        }
        
    }
}
