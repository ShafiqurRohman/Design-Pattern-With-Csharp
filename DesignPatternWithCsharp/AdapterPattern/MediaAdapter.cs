using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.AdapterPattern
{
    class MediaAdapter : MediaPlayer
    {
        AdvanceMediaPlayer advanceMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if(audioType.Equals("vlc", StringComparison.InvariantCultureIgnoreCase))
            {
                advanceMediaPlayer = new VlcPlayer();
            }
            else
            {
                advanceMediaPlayer = new Mp4Player();
            }
        }

        public void play(string audioType, string fileName)
        {
            if(audioType.Equals("vlc", StringComparison.CurrentCultureIgnoreCase))
            {
                advanceMediaPlayer.playVlc(fileName);
            }
            else
            {
                advanceMediaPlayer.playMp4(fileName);
            }
        }
    }
}
