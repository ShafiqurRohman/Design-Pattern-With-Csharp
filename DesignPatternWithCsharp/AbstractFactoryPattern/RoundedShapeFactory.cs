using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternWithCsharp.FactoryPattern;

namespace DesignPatternWithCsharp.AbstractFactoryPattern
{
    class RoundedShapeFactory : ShapeFactory
    {
        public override Shape GetShape(string shapeType)
        {
            if(shapeType.Equals("ROUNDEDRACTANGLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new RoundedRectangle();
            }
            else if(shapeType.Equals("ROUNDEDSQUEAR", StringComparison.InvariantCultureIgnoreCase))
            {
                return new RoundedSquare();
            }
            else return null;
        }
    }
}
