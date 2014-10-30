using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessLogic;
namespace ChessLogic
{
    class Interface
    {
        static void Main(string[] args)
        {
                Pawn wp1 = new Pawn(new PairPos(0, 12));
                Pawn wp2 = new Pawn(new PairPos(10, 12));
                Pawn wp3 = new Pawn(new PairPos(20, 12));
                Pawn wp4 = new Pawn(new PairPos(30, 12));
                Pawn wp5 = new Pawn(new PairPos(40, 12));
                Pawn wp6 = new Pawn(new PairPos(50, 12));
                Pawn wp7 = new Pawn(new PairPos(60, 12));
                Pawn wp8 = new Pawn(new PairPos(70, 12));

                wp1.SkrivUt(wp1);
                wp2.SkrivUt(wp2);
                wp3.SkrivUt(wp3);
                wp4.SkrivUt(wp4);
                wp5.SkrivUt(wp5);
                wp6.SkrivUt(wp6);
                wp7.SkrivUt(wp7);
                wp8.SkrivUt(wp8);
                Console.ReadLine();
        }
    }
}
