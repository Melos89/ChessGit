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
           bool ActiveGame = true;
           ColoursEnum EC = new ColoursEnum(); //The Enum thing
           int W = (int)EC.w;
           int B = (int)EC.b;
           Pawn wp1 = new Pawn(new PairPos(0,  30),"W","Pawn");//Creates pawns with x and y co-ordinates and assigning colour
           Pawn wp2 = new Pawn(new PairPos(10, 30), "W", "Pawn");//W = White, B = Black and type = pawn.
           Pawn wp3 = new Pawn(new PairPos(20, 30), "W", "Pawn");
           Pawn wp4 = new Pawn(new PairPos(30, 30), "W", "Pawn");
           Pawn wp5 = new Pawn(new PairPos(40, 30), "W", "Pawn");
           Pawn wp6 = new Pawn(new PairPos(50, 30), "W", "Pawn");
           Pawn wp7 = new Pawn(new PairPos(60, 30), "W", "Pawn");
           Pawn wp8 = new Pawn(new PairPos(70, 30), "W", "Pawn");
           Pawn bp1 = new Pawn(new PairPos(0, 5), "B", "Pawn");
           Pawn bp2 = new Pawn(new PairPos(10, 5), "B", "Pawn");
           Pawn bp3 = new Pawn(new PairPos(20, 5), "B", "Pawn");
           Pawn bp4 = new Pawn(new PairPos(30, 5), "B", "Pawn");
           Pawn bp5 = new Pawn(new PairPos(40, 5), "B", "Pawn");
           Pawn bp6 = new Pawn(new PairPos(50, 5), "B", "Pawn");
           Pawn bp7 = new Pawn(new PairPos(60, 5), "B", "Pawn");
           Pawn bp8 = new Pawn(new PairPos(70, 5), "B", "Pawn");


           List<ChessPieces> WhitePieces = new List<ChessPieces>();//Creates a list for white folk and
           List<ChessPieces> BlackPieces = new List<ChessPieces>();//for the other mongrels



           WhitePieces.Add(wp1);//Adds all white pieces to a list.
           WhitePieces.Add(wp2);
           WhitePieces.Add(wp3);
           WhitePieces.Add(wp4);
           WhitePieces.Add(wp5);
           WhitePieces.Add(wp6);
           WhitePieces.Add(wp7);
           WhitePieces.Add(wp8);
           BlackPieces.Add(bp1);//Adds all black pieces to list.
           BlackPieces.Add(bp2);
           BlackPieces.Add(bp3);
           BlackPieces.Add(bp4);
           BlackPieces.Add(bp5);
           BlackPieces.Add(bp6);
           BlackPieces.Add(bp7);
           BlackPieces.Add(bp8);

         



           PlayerAI PlayerWhite = new PlayerAI(WhitePieces);//Gives Mr White a list of white pieces
           PlayerAI PlayerBlack = new PlayerAI(BlackPieces);//Gives Mr Black a list of black pieces

           MovePieces moving = new MovePieces();
           List<ChessPieces> WhiteList = PlayerWhite.CanPiecesMove(WhitePieces);
           List<ChessPieces> BlackList = PlayerBlack.CanPiecesMove(BlackPieces);
           foreach (var wpieces in WhiteList)
           {
               wpieces.TellUs(wpieces);
           }
           foreach (var bpieces in BlackPieces)
           {
               bpieces.TellUs(bpieces);
           }

           while (ActiveGame)
           {
               ClearTheBoard();
               WhiteList = PlayerWhite.CanPiecesMove(WhitePieces);
               foreach (var wpieces in WhiteList)
               {
                   wpieces.TellNewPosition(wpieces);
               }
               foreach (var bpieces in BlackPieces)
               {
                   bpieces.TellNewPosition(bpieces);
               }
               moving.MoveNow(moving.MoveThis(WhitePieces));
               //Method for choosing a piece from list to move here. Random engine?
               //Method for changing X and Y pos of piece here
               BlackList = PlayerBlack.CanPiecesMove(BlackPieces);
               moving.MoveNow(moving.MoveThis(BlackPieces));
               Console.ReadKey();
               //Method for choosing a piece from list to move here. Random engine?
               //Method for changing X and Y pos of piece here
               //Final method for turning ActiveGame = false; Basically method call both lists and if they return empty exit, for now.

           }

           
       } 
       public void ClearTheBoard()
       {
           Console.Clear();
       }

    }
}
