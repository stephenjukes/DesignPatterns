using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Resources.Artists
{
    class NoelGallagher : IArtist
    {
        public string Url { get; set; } = "www.noelgallagher.com";
        public string Name { get; set; } = "Noel Gallagher";
        public string Bio { get; set; } = "Noel Gallagher was the vocalist and lead guitarist in the 1990s alternative rock band Oasis. He began a solo career after quitting Oasis in 2009.";
        public string Photo { get; set; } = GetPhoto(30, 10);

        private static string GetPhoto(int width, int height)
        {
            string w = "   ";
            string image = "";

            for (var i = 0; i < width; i++)
            {
                w += "*";
            }

            w += "\n";

            for (var row = 0; row < height; row++)
            {
                image += w;
            }

            return image;
        }

    }
}
