using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
   public class MovePieces //Class for moving pieces off their starting co-ordinates.
    {
        protected PairPos Location; //Iniated a co-ord class called Location

        public PairPos GetLocation() //Gets the value 
        {
            return Location;
            //(((Use to fetch location in logger and then print in cmd?)))
        }
        public void SetLocation(PairPos NewLocation) //Sets the value
        {
            Location = NewLocation;
            //(((Method to select new location inside PlayerAI???)))
        }

    }
}
