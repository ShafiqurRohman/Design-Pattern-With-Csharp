using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.AdapterPattern
{
    class Mp4Player : AdvanceMediaPlayer
    {
        public void playVlc(string fileName)
        {

        }

        public void playMp4(string fileName)
        {
            Console.WriteLine("The Mp4 file {0} is playing", fileName);
        }
    }
}
