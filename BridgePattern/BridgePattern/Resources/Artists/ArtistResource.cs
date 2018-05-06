using BridgePattern.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class ArtistResource : IResource
    {
        IArtist _artist;

        public ArtistResource(IArtist artist)
        {
            _artist = artist;
        }

        public string Url()
        {
            return _artist.Url;
        }

        public string Title()
        {
            return _artist.Name;
        }

        public string Snippet()
        {
            return _artist.Bio;
        }

        public string Image()
        {
            return _artist.Photo;
        }
    }
}
