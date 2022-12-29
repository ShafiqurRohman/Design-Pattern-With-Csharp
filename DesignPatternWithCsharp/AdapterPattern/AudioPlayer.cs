using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.AdapterPattern
{
    class AudioPlayer : MediaPlayer
    {
        public void play(string audioType, string fileName)
        {
            if(audioType.Equals("mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("The Mp3 file playing : {0}", fileName);
            }
            else if(audioType.Equals("vlc", StringComparison.InvariantCultureIgnoreCase) ||
                audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
              MediaAdapter  mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.play(audioType, fileName);
            }
            else{
                Console.WriteLine("Invalid media type {0} file not supported", audioType);
            }
        }
    }
}
