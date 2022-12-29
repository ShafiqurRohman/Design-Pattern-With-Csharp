using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.PrototypePattern
{
    class Circle : Shape
    {
        public Circle()
        {
            type = "Circle";
        }

        public override void draw()
        {
            Console.WriteLine("Inside Circle Draw::method");
        }
    }
}
