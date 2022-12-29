using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.FactoryPattern
{
    class ShapeFactory
    {
        public Shape GetShape(string shapeType)
        {
            if(shapeType == null)
            {
                return null;
            }
            else if(shapeType.Equals("CIRCLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Circle();
            }
            else if(shapeType.Equals("RECTANGLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Rectangle();
            }
            else if(shapeType.Equals("SQUARE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Square();
            }
            return null;
            
        }
    }
}
