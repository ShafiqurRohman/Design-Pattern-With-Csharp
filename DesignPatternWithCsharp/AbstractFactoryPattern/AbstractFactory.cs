using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternWithCsharp.FactoryPattern;

namespace DesignPatternWithCsharp.AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract Shape GetShape(string shapeType);
    }
}
