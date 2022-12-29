using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.BridgePattern
{
    class RedCircle : DrawApi
    {
        public void drawCircle(int radious, int x, int y)
        {
            Console.WriteLine("The redious Red Circle is {0} and the x and y are {1} and {2}", radious, x, y);
        }
    }
}
