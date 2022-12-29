using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternWithCsharp.FactoryPattern;

namespace DesignPatternWithCsharp.AbstractFactoryPattern
{
    class RoundedRectangle : Shape
    {
        public Shape draw()
        {
            Console.WriteLine("This is Rounded Rectangel shape");
            return this;
        }
    }
}
