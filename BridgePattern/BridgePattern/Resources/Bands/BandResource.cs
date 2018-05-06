using BridgePattern.Resources.Bands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class BandResource : IResource
    {
        IBand _band;

        public BandResource(IBand band)
        {
            _band = band;
        }

        public string Url()
        {
            return _band.Url;
        }

        public string Title()
        {
            return _band.Name;
        }

        public string Snippet()
        {
            return _band.History;
        }

        public string Image()
        {
            return _band.Photo;
        }
    }
}
