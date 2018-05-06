using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Resources.Songs
{
    class Wonderwall : ISong
    {
        public string Url { get; set; } = "www.oasis/wonderwall.com";
        public string Title { get; set; } = "Wonderwall";
        public string Lyrics { get; set; } = "Today is gonna be the day that they're gonna throw it back to you\nBy now you should've somehow realized what you gotta do…";
        public string SingleCover { get; set; } = "This is a photo of the Wonderwall single cover";
    }
}
