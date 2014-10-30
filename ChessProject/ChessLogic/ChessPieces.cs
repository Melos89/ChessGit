using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public abstract class ChessPieces
    {
        public int Strength;
        public string type;
        public PairPos XYPos;
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public virtual void TellPosition()
        {
            Console.Write( " is at position [" + PositionX + "," + PositionY + "]");
        }
        public void SkrivUt(ChessPieces piece)
        {
            piece.TellPosition();
        }
    }
}
