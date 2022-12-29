using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.BridgePattern
{
    class Circle : Shape
    {
        int radious, x, y;
        public Circle(int redious, int x, int y, DrawApi drawApi) : base(drawApi)
        {
            this.radious = redious;
            this.x = x;
            this.y = y;
        }

        public override void draw()
        {
            drawApi.drawCircle(radious, x, y);
        }
    }
}
