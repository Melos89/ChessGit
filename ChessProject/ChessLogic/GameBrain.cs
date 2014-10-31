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
           ColoursEnum EC = new ColoursEnum();
           int w = (int)EC.w;
           int b = (int)EC.b;
           Pawn wp1 = new Pawn(new PairPos(0,  30), w,"Pawn");//Creates pawns with x and y co-ordinates and assigning colour
           //Pawn wp2 = new Pawn(new PairPos(10, 30), "W","Pawn");//W = White, B = Black
           //Pawn wp3 = new Pawn(new PairPos(20, 30), "W","Pawn");
           //Pawn wp4 = new Pawn(new PairPos(30, 30), "W", "Pawn");
           //Pawn wp5 = new Pawn(new PairPos(40, 30), "W", "Pawn");
           //Pawn wp6 = new Pawn(new PairPos(50, 30), "W", "Pawn");
           //Pawn wp7 = new Pawn(new PairPos(60, 30), "W", "Pawn");
           //Pawn wp8 = new Pawn(new PairPos(70, 30), "W", "Pawn");
           //Pawn bp1 = new Pawn(new PairPos(0 , 5), "B", "Pawn");
           //Pawn bp2 = new Pawn(new PairPos(10, 5), "B", "Pawn");
           //Pawn bp3 = new Pawn(new PairPos(20, 5), "B", "Pawn");
           //Pawn bp4 = new Pawn(new PairPos(30, 5), "B", "Pawn");
           //Pawn bp5 = new Pawn(new PairPos(40, 5), "B", "Pawn");
           //Pawn bp6 = new Pawn(new PairPos(50, 5), "B", "Pawn");
           //Pawn bp7 = new Pawn(new PairPos(60, 5), "B", "Pawn");
           //Pawn bp8 = new Pawn(new PairPos(70, 5), "B", "Pawn");


           List<ChessPieces> pieces = new List<ChessPieces>();//Creates a list for white folk and for the other mongrels



           pieces.Add(wp1);//Adds all white pieces to a list.
           //pieces.Add(wp2);
           //pieces.Add(wp3);
           //pieces.Add(wp4);
           //pieces.Add(wp5);
           //pieces.Add(wp6);
           //pieces.Add(wp7);
           //pieces.Add(wp8);
           //pieces.Add(bp1);//Adds all black pieces to list.
           //pieces.Add(bp2);
           //pieces.Add(bp3);
           //pieces.Add(bp4);
           //pieces.Add(bp5);
           //pieces.Add(bp6);
           //pieces.Add(bp7);
           //pieces.Add(bp8);

         

               

               foreach (var item in pieces)//Loop that calls the TellUs method in the ChessPieces class(Not needed here)
               {
                   
                   item.TellUs(item);
               }




           PlayerAI PlayerWhite = new PlayerAI(pieces);//Gives Mr White a list of white pieces
           PlayerAI PlayerBlack = new PlayerAI(pieces);//Gives Mr Black a list of black pieces

           
       } 
       public void ClearTheBoard()
       {
           Console.Clear();
       }

    }
}
