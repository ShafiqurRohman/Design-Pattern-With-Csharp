using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.AdapterPattern
{
    interface MediaPlayer
    {
        public void play(string audioType, string fileName);
    }
}
