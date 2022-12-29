using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.AdapterPattern
{
    class VlcPlayer : AdvanceMediaPlayer
    {
        public void playVlc(string fileName)
        {
            Console.WriteLine("The vlc file {0} is playing", fileName);
        }

        public void playMp4(string fileName)
        {

        }
    }
}
