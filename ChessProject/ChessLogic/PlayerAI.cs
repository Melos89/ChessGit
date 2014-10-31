using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class PlayerAI
    {
        List<ChessPieces> Pieces; //Iniated a list to hold Chess pieces

        Random randomizer = new Random(); // Initiated a new random class
        
        public PlayerAI(List<ChessPieces> pieces)//PlayerAI construct that takes in a list.
        {
           Pieces = pieces;
        }
        //public ChessPieces RandomChesspiece(List<ChessPieces> pieces) //Randomly picks an item from the length of the list. ((Unfinished/Work in progress))
        //{
        //    //int svar = randomizer.Next(pieces.Count);as.
        //    //pieces.GetEnumerator();
        //    //return pieces;
        //}

        //public void moveBits(List<ChessPieces> pieces)  //trying to get and set new values for pieces.
        //{                                                //wrong location for this method?
        //    foreach (var item in pieces)
        //    {
        //        PairPos test = item.GetLocation();
        //        item.SetLocation(test);
        //    }
        //}
    }
}
