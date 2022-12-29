using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.FactoryPattern
{
    public class Circle : Shape
    {
        public Shape draw()
        {
            Console.WriteLine("This is a Circle shape");
            return this;
        }
    }
}
