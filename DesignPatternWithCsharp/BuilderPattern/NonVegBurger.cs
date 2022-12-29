using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.BuilderPattern
{
    class NonVegBurger : Burger
    {
        public override string name()
        {
            return "NonVegBurger";
        }
        public override float price()
        {
            return 80.5f;
        }
    }
}
