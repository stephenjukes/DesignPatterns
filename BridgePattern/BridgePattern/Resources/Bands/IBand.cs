using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Resources.Bands
{
    interface IBand
    {
        string Url { get; set; }
        string Name { get; set; }
        string History { get; set; }
        string Photo { get; set; }
    }
}
