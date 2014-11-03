﻿using System;
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
           Pawn wp1 = new Pawn(new PairPos(0,  30),"W","Pawn", 10);//Creates pawns with x and y co-ordinates and assigning colour
           Pawn wp2 = new Pawn(new PairPos(10, 30), "W", "Pawn", 10);//W = White, B = Black and type = pawn.
           Pawn wp3 = new Pawn(new PairPos(20, 30), "W", "Pawn", 10);
           Pawn wp4 = new Pawn(new PairPos(30, 30), "W", "Pawn", 10);
           Pawn wp5 = new Pawn(new PairPos(40, 30), "W", "Pawn", 10);
           Pawn wp6 = new Pawn(new PairPos(50, 30), "W", "Pawn", 10);
           Pawn wp7 = new Pawn(new PairPos(60, 30), "W", "Pawn", 10);
           Pawn wp8 = new Pawn(new PairPos(70, 30), "W", "Pawn", 10);
           Pawn bp1 = new Pawn(new PairPos(0, 5), "B", "Pawn", 20);
           Pawn bp2 = new Pawn(new PairPos(10, 5), "B", "Pawn", 20);
           Pawn bp3 = new Pawn(new PairPos(20, 5), "B", "Pawn", 20);
           Pawn bp4 = new Pawn(new PairPos(30, 5), "B", "Pawn", 20);
           Pawn bp5 = new Pawn(new PairPos(40, 5), "B", "Pawn", 20);
           Pawn bp6 = new Pawn(new PairPos(50, 5), "B", "Pawn", 20);
           Pawn bp7 = new Pawn(new PairPos(60, 5), "B", "Pawn", 20);
           Pawn bp8 = new Pawn(new PairPos(70, 5), "B", "Pawn", 20);


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



           Console.ReadLine();

           while (ActiveGame)
           {
               ClearTheBoard();
               foreach (var wpiece in WhitePieces)
               {
                   wpiece.TellUs(wpiece);
                   foreach (var bpiece in BlackPieces)
                   {
                       bpiece.TellUs(bpiece);
                   }
               }
               List<ChessPieces> WhitesList = PlayerWhite.CanPiecesMove(WhitePieces);
               //MoveThis(WhiteList);
               Console.ReadLine();
               //Method for choosing a piece from list to move here. Random engine?
               //Method for changing X and Y pos of piece here
               List<ChessPieces> BlackList = PlayerBlack.CanPiecesMove(BlackPieces);
               //Method for choosing a piece from list to move here. Random engine?
               //Method for changing X and Y pos of piece here
               //Final method for turning ActiveGame = false; Basically method call to see if anything can move. if else, exit

           }

           
       } 
       public void ClearTheBoard()
       {
           Console.Clear();
       }

    }
}
