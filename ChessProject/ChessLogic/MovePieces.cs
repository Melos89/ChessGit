using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
   public class MovePieces 
    {
        protected PairPos Location;

        public PairPos GetLocation()
        {
            return Location;
        }
        public void SetLocation(PairPos NewLocation)
        {
            Location = NewLocation;
        }

    }
}
