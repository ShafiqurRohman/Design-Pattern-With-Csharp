using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.PrototypePattern
{
    public class ShapeCache
    {
        private static Hashtable shapeMap = new Hashtable();

        public static Shape getShape(string shapeId)
        {
            Shape cacheShape = shapeMap[shapeId] as Shape;
            return (Shape)cacheShape.Clone();
        }

        public static void loadCache()
        {
            Circle circle = new Circle();
            circle.setId("1");
            shapeMap.Add(circle.getId(), circle);

            Square square= new Square();
            square.setId("2");
            shapeMap.Add(square.getId(), square);

            Rectangular rectangular = new Rectangular();
            rectangular.setId("3");
            shapeMap.Add(rectangular.getId(), rectangular);
        }
    }
}
