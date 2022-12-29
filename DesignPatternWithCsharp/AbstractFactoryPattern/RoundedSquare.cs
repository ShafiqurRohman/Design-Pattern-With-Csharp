using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternWithCsharp.FactoryPattern;

namespace DesignPatternWithCsharp.AbstractFactoryPattern
{
    class RoundedSquare : Shape
    {
        public Shape draw()
        {
            Console.WriteLine("This is rounded Square");
            return this;
        }
    }
}
