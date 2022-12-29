using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.BuilderPattern
{
    class Coke : ColdDrink
    {
        public override string name()
        {
            return "Coke";
        }
        public override float price()
        {
            return 45.5f;
        }
    }
}
