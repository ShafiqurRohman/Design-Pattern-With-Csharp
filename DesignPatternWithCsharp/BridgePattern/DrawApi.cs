using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.BridgePattern
{
    public interface DrawApi
    {
        public void drawCircle(int radious, int x, int y);
    }
}
