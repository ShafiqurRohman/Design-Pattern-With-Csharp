using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.AdapterPattern
{
    interface AdvanceMediaPlayer
    {
        public void playVlc(string fileName);
        public void playMp4(string fileName);
    }
}
