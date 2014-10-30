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

           Pawn wp1 = new Pawn(new PairPos(0,  30), "W");//Creates pawns with x and y co-ordinates and assigning colour
           Pawn wp2 = new Pawn(new PairPos(10, 30), "W");
           Pawn wp3 = new Pawn(new PairPos(20, 30), "W");
           Pawn wp4 = new Pawn(new PairPos(30, 30), "W");
           Pawn wp5 = new Pawn(new PairPos(40, 30), "W");
           Pawn wp6 = new Pawn(new PairPos(50, 30), "W");
           Pawn wp7 = new Pawn(new PairPos(60, 30), "W");
           Pawn wp8 = new Pawn(new PairPos(70, 30), "W");
           Pawn bp1 = new Pawn(new PairPos(0,  5), "B");
           Pawn bp2 = new Pawn(new PairPos(10, 5), "B");
           Pawn bp3 = new Pawn(new PairPos(20, 5), "B");
           Pawn bp4 = new Pawn(new PairPos(30, 5), "B");
           Pawn bp5 = new Pawn(new PairPos(40, 5), "B");
           Pawn bp6 = new Pawn(new PairPos(50, 5), "B");
           Pawn bp7 = new Pawn(new PairPos(60, 5), "B");
           Pawn bp8 = new Pawn(new PairPos(70, 5), "B");



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

           blackPieces.Add(bp1);//Adds all black pieces to Another list.
           blackPieces.Add(bp2);
           blackPieces.Add(bp3);
           blackPieces.Add(bp4);
           blackPieces.Add(bp5);
           blackPieces.Add(bp6);
           blackPieces.Add(bp7);
           blackPieces.Add(bp8);

           foreach (var item in whitePieces)
           {
               item.SkrivUt(item);
           }

           foreach (var item in blackPieces)
           {
               item.SkrivUt(item);
           }


           PlayerAI PlayerWhite = new PlayerAI(whitePieces);//Gives player white a list of white pieces
           PlayerAI PlayerBlack = new PlayerAI(blackPieces);//Gives player black a list of black pieces


       }        

    }
}
