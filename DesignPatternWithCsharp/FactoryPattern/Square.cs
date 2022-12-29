using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.FactoryPattern
{
    class Square : Shape
    {
        public Shape draw()
        {
            Console.WriteLine("This is a square shape");
            return this;
        }
    }
}
