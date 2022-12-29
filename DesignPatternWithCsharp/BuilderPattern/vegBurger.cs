using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.BuilderPattern
{
    class vegBurger : Burger
    {
        public override string name()
        {
            return "VegBurger";
        }
        public override float price()
        {
            return 120.5f;
        }
    }
}
