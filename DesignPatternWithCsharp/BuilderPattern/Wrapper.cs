using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.BuilderPattern
{
    class Wrapper : Packing
    {
        public string pack()
        {
            return "Wrapper";
        }
    }
}
