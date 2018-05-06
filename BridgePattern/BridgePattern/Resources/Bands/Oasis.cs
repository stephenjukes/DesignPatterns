using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Resources.Bands
{
    class Oasis : IBand
    {
        public string Url { get; set; } = "www.oasis.com";
        public string Name { get; set; } = "Oasis";
        public string History { get; set; } = "Oasis are formed after Paul 'Bonehead' Arthurs, Paul 'Guigsy' McGuigan and Tony McCarrol ask Liam Gallagher to join their band Rain and he suggests that they change their name. Later his brother Noel is invited to join. He says he will, but only if he can be boss.";
        public string Photo { get; set; } = "This is a photo of Oasis";
    }
}
