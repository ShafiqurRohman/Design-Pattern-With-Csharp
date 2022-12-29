using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.PrototypePattern
{
    public class Rectangular : Shape
    {
        public Rectangular()
        {
            type = "Rectangular";
        }
        public override void draw()
        {
            Console.WriteLine("Inside Ractangle Draw::method");
        }
    }
}
