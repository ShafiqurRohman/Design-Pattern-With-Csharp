using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.BuilderPattern
{
    class Pepsi  : ColdDrink
    {
        public override string name()
        {
            return "Pepsi";
        }
        public override float price()
        {
            return 40.5f;
        }
    }
}
