using BridgePattern.Resources.Songs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class SongResource : IResource
    {
        ISong _song;

        public SongResource(ISong song)
        {
            _song = song;
        }

        public string Url()
        {
            return $"www.{_song.Title}.com";
        }

        public string Title()
        {
            return _song.Title;
        }

        public string Snippet()
        {
            return _song.Lyrics;
        }

        public string Image()
        {
            return _song.SingleCover;
        }
    }
}
