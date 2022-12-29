using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.FactoryPattern
{
    class Rectangle : Shape
    {
        public Shape draw()
        {
            Console.WriteLine("this is a Rectangle shape");
            return this;
        }
    }
}
