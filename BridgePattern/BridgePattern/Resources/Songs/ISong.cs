using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Resources.Songs
{
    interface ISong
    {
        string Url { get; set; }
        string Title { get; set; }
        string Lyrics { get; set; }
        string SingleCover { get; set; }
    }
}
