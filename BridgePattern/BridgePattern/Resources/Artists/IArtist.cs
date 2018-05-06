using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Resources
{
    interface IArtist
    {
        string Url { get; set; }
        string Name { get; set; }
        string Bio { get; set; }
        string Photo { get; set; }
    }
}
