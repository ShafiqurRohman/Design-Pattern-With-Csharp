using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.PrototypePattern
{
    class Square : Shape
    {
        public Square()
        {
            type = "Square";
        }

        public override void draw()
        {
            Console.WriteLine("Inside Square Draw::method");
        }
    }
}
