using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternWithCsharp.FactoryPattern;

namespace DesignPatternWithCsharp.AbstractFactoryPattern
{
    public class ShapeFactory : AbstractFactory
    {
        public override Shape GetShape(string shapeType)
        {
            if (shapeType.Equals("CIRCLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Circle();
            }
            else if (shapeType.Equals("RECTANGLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("SQUARE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Square();
            }
            else return null;
        }
    }
}
