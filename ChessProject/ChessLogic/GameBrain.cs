using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
   public class GameBrain
    {
       public GameBrain()
       {

           Pawn wp1 = new Pawn(new PairPos(0, 12));//Creates pawns with x and y co-ordinates.
           Pawn wp2 = new Pawn(new PairPos(10, 12));
           Pawn wp3 = new Pawn(new PairPos(20, 12));
           Pawn wp4 = new Pawn(new PairPos(30, 12));
           Pawn wp5 = new Pawn(new PairPos(40, 12));
           Pawn wp6 = new Pawn(new PairPos(50, 12));
           Pawn wp7 = new Pawn(new PairPos(60, 12));
           Pawn wp8 = new Pawn(new PairPos(70, 12));
           Pawn bp1 = new Pawn(new PairPos(0, 6));
           Pawn bp2 = new Pawn(new PairPos(10, 6));
           Pawn bp3 = new Pawn(new PairPos(20, 6));
           Pawn bp4 = new Pawn(new PairPos(30, 6));
           Pawn bp5 = new Pawn(new PairPos(40, 6));
           Pawn bp6 = new Pawn(new PairPos(50, 6));
           Pawn bp7 = new Pawn(new PairPos(60, 6));
           Pawn bp8 = new Pawn(new PairPos(70, 6));


           List<ChessPieces> whitePieces = new List<ChessPieces>();//Creates a list for white folk
           List<ChessPieces> blackPieces = new List<ChessPieces>();//Creates a list for the other mongrels


           whitePieces.Add(wp1);//Adds all white pieces to a list.
           whitePieces.Add(wp2);
           whitePieces.Add(wp3);
           whitePieces.Add(wp4);
           whitePieces.Add(wp5);
           whitePieces.Add(wp6);
           whitePieces.Add(wp7);
           whitePieces.Add(wp8);

           blackPieces.Add(bp1);//Adds all black pieces to another list.
           blackPieces.Add(bp2);
           blackPieces.Add(bp3);
           blackPieces.Add(bp4);
           blackPieces.Add(bp5);
           blackPieces.Add(bp6);
           blackPieces.Add(bp7);
           blackPieces.Add(bp8);


       }


       //public List<ChessPieces> gamePieces(ChessPieces piece)
       // {
       //     List<ChessPieces> whitePieces = new List<ChessPieces>();
       //     List<ChessPieces> blackPieces = new List<ChessPieces>();
       //     if (piece.type == "white")
       //     {
       //         whitePieces.Add(piece);
       //         return whitePieces;
       //     }
       //     else
       //     {
       //         blackPieces.Add(piece);
       //         return blackPieces;
       //     }
       // }
        

    }
}
