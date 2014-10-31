using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class colors
    {
        enum soldiers {W = 22, B};

        static void Main()
        {
            int x = (int)soldiers.W;
            int y = (int)soldiers.B;
            Console.WriteLine("W = {0}", x);
            Console.WriteLine("B = {0}", y);
            Console.ReadLine();
        }
    }
    /* Output:
       Sun = 0
       Fri = 5
    */
}
