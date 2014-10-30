using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class PairPos //Class for assigning Coordinates to pieces
    {
            public int X;
            public int Y;
            public PairPos(int x, int y) //Construct that allows different pieces to get coordinates
            {
                X = x;
                Y = y;
            }
    }
}
